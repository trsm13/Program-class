using System;
using System.Collections.Generic;
using System.Text;

namespace Program_class
{
    /// <summary>
    /// 
    /// </summary>
    class Photography
    {

    }
}
//*************************************
//
//Title: Photography
//Application Type: Console
//Description: Ask user what type of Photography,opening and closing screens, and the menu to ask questions
//Author: Moreno, Teresia
//Dated Created: 03/30/2021
//Last Modified: 04/04/2021
//
//**************************************

class Program
{
    static int photography;
    static int steet;
    static int wildlife;
    static int people;
}

/// <summary>
/// setup the console theme
/// </summary>
static void SetTheme()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.BackgroundColor = ConsoleColor.White;
}


/// <summary>
/// ****************************************
/// *          Main Menu                   *
/// ****************************************
/// </summary>
static void DisplayMenuScreen()
{
    Console.CursorVisible = true;

    bool quitApplication = false;
    string menuChoice;


}

/// <summary>
/// ******************************************
/// *            Welcome Screen              *
/// ******************************************
/// </summary>
static void DisplayWelcomeScreen()
{
    Console.CursorVisible = false;

    Console.Clear();
    Console.WriteLine();
    Console.WriteLine("\t\t");
    Console.WriteLine();

    DisplayContinuePrompt();
}

/// <summary>
/// ****************************************
/// *               Closing Screen         *
/// ****************************************
/// </summary>
static void DisplayClosingScreen()
{
    Console.CursorVisible = false;

    Console.Clear();
    Console.WriteLine();
    Console.WriteLine("\t\t Thank you for....");
    Console.WriteLine();

    DisplayContinuePrompt();
}
///<summary>
///display continue prompt
/// </summary>
static void DisplayContinuePrompt()
{
    Console.WriteLine();
    Console.WriteLine("\tPress any key to contnue.");
    Console.ReadKey();
}

///<summary>
///display screen header
/// </summary>
static void DisplayScreenHeader(string headerText)
{
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine("\t\t" + headerText);
    Console.WriteLine();
}
#endregion