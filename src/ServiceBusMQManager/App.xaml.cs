#region File Information
/********************************************************************
  Project: ServiceBusMQManager
  File:    App.xaml.cs
  Created: 2012-08-21

  Author(s):
    Daniel Halan

 (C) Copyright 2012 Ingenious Technology with Quality Sweden AB
     all rights reserved

********************************************************************/
#endregion

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using ServiceBusMQ;

namespace ServiceBusMQManager {
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application {

    enum ArgType { Send, Silent }

    class Arg {
      public ArgType Type { get; set; }
      public string Param { get; set; }

      public Arg(ArgType type, string param) {
        Type = type;
        Param = param;
      }
    }


    bool _silent;

    [DllImport("Kernel32.dll")]
    public static extern bool AttachConsole(int processId);
    
    protected override void OnStartup(StartupEventArgs e) {


      if( e.Args.Length >= 1 ) {
        AttachConsole(-1);

        List<Arg> args = ProcessArgs(e.Args);

        _silent = args.Any(a => a.Type == ArgType.Silent);

        PrintHeader();

        var arg = args.FirstOrDefault(a => a.Type == ArgType.Send);
        if( arg != null ) {
          string cmdName = arg.Param;

          var sys = SbmqSystem.Create();
          try {
            var cmd = sys.SavedCommands.Items.FirstOrDefault(c => c.DisplayName == cmdName);

            if( cmd != null ) {
              Out(string.Format("Sending Command '{0}'...", cmdName));
              sys.SendCommand(cmd.Server, cmd.Transport, cmd.Command);

            } else {
                Out(string.Format("No Command with name '{0}' found, exiting...", cmdName));
            }
          
          } finally {
            sys.Manager.Dispose();
          }

        } else {
          PrintHelp();
        }

        Application.Current.Shutdown(0);
        return;
      }

      // Check if we are already running...
      Process currProc = Process.GetCurrentProcess();
      Process existProc = Process.GetProcessesByName(currProc.ProcessName).Where(p => p.Id != currProc.Id).FirstOrDefault();
      if( existProc != null ) {
        try {
          // Show the already started SBMQM
          WindowTools.EnumWindows(new WindowTools.EnumWindowsProc((hwnd, lparam) => {
              uint procId;
              WindowTools.GetWindowThreadProcessId(hwnd, out procId);
              if( procId == existProc.Id ) {
                if( WindowTools.SendMessage(hwnd, ServiceBusMQManager.MainWindow.WM_SHOWWINDOW, 0, 0) == 1 )
                  return false;
              }
              return true;
            }), 0);

        } finally {
          Application.Current.Shutdown();
        }
        return;
      }

      base.OnStartup(e);
    }


    private void PrintHeader() {
      Out(string.Empty);
      Out("===============================================================================");
      Out("  Service Bus MQ Manager v2.00 - (c)2012 ITQ.COM, Daniel Halan http://halan.se");
      Out("===============================================================================");
    }

    private void PrintHelp() {

      
      Out(" Command Line: ServiceBusMQManager.exe --send <recentCommandName> [-s]");
      //Out("                                [-px <name> <value>]");

      Out("");
      Out("  --send   = Send a saved command");
      Out("  -s       = Silent Mode");


    }

    private void Out(string str) {
      if( !_silent ) 
        Console.WriteLine(str);
    }

    private List<Arg> ProcessArgs(string[] args) {
      List<Arg> r = new List<Arg>();

      try {

        for( int i = 0; i < args.Length; i++ )
          switch( args[i] ) {
            case "--send": r.Add(new Arg(ArgType.Send, args[++i])); break;
            case "-s": r.Add(new Arg(ArgType.Silent, null)); break;
          }

      } catch( Exception e ) {
        Console.WriteLine("Failed when parsing arguments, " + e.Message);
      }

      return r;
    }



    static AssemblyName _info;
    public static AssemblyName Info {
      get {
        if( _info == null )
          _info = Assembly.GetExecutingAssembly().GetName();

        return _info;
      }
    }


    private void Application_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e) {

#if !DEBUG
      MessageBox.Show(e.Exception.Message +"\n\r" + e.Exception.StackTrace, "Exception Caught", MessageBoxButton.OK, MessageBoxImage.Error);
      e.Handled = true;
#endif

    }



  }
}
