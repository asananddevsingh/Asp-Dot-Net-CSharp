using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part_071
{
    /// <summary>
    /// Part 071 : Code snippets in visual studio
    /// </summary>
    class Program
    {
        /*
         * Code snippets are ready-made snippets of code you can quickly insert into your code.
         * 1. Keyboard shortcut: Ctrl K + X.
         * 2. Right click and select "Insert snippet....", from the context menu.
         * 3. Click Edit-Intellisense - Insert Snippet.
         * 4. Use code snippints short cut. For example to use "for loop", type "for" and press TAB key twice.
         * 5. Once ca code snippet is inserted, the editabele fields are highlighted in yellow, 
         *      and the first editable field is selected automatically.
         *      Upon channging the first field, press TAB to move to the next editable field. 
         *      To come to the prvious editable fields use Shift + TAB. 
         *      Press ENTER or ESC keys to cancel field editing and return to the code editor to normal.
         *  6. Code Snippet Types::
         *      > Expansion: These snippets allow the code to be inserted at the cursor position.
         *      > Surrounds with: THese snippets allow the code snippet to be placed around a selected piece of code.
         *      > Refactoring: These snippets are used during code refactoring.
         */
        static void Main(string[] args)
        {
            StringBuilder notes = new StringBuilder();

            notes.Append("Code snippets are ready-made snippets of code you can quickly insert into your code.\n");
            notes.Append(" 1. Keyboard shortcut: Ctrl K + X.\n");
            notes.Append(" 2. Right click and select \"Insert snippet....\", from the context menu..\n");
            notes.Append(" 3. Click Edit-Intellisense - Insert Snippet..\n");
            notes.Append(" 4. Use code snippints short cut. For example to use \"for loop\", type \"for\" and press TAB key twice..\n");
            notes.Append(" 5. Once ca code snippet is inserted, the editabele fields are highlighted in yellow,.\n");
            notes.Append(" and the first editable field is selected automatically..\n");
            notes.Append(" Upon channging the first field, press TAB to move to the next editable field. .\n");
            notes.Append(" To come to the prvious editable fields use Shift + TAB. .\n");
            notes.Append(" Press ENTER or ESC keys to cancel field editing and return to the code editor to normal..\n");
            notes.Append(" 6. Code Snippet Types::.\n");
            notes.Append(" > Expansion: These snippets allow the code to be inserted at the cursor position..\n");
            notes.Append(" > Surrounds with: THese snippets allow the code snippet to be placed around a selected piece of code..\n");
            notes.Append(" > Refactoring: These snippets are used during code refactoring..\n");

            Console.WriteLine(notes);

            Console.ReadKey();
        }
    }
}
