# Ending-Balance-Application
A C# Windows Forms application that calculates the ending balance of an account with monthly interest over a user-defined number of months. Great for practicing loops, basic arithmetic, and GUI handling in C#.

# Features
Enter a starting balance and number of months.
Calculates monthly interest using a fixed interest rate (0.5%).
Displays a detailed list of balances for each month.
Shows the final ending balance.
Buttons to Calculate, Clear, and Exit the application.

# How to Run
Clone or download the repository.
Open the project in Visual Studio.
Make sure the form contains the following controls:
-txtstartingBal (TextBox for starting balance)
-txtmonths (TextBox for number of months)
-btnCalculate (Button to calculate ending balances)
-btnClear (Button to reset the form)
-lstDetailList (ListBox to show monthly balances)
-lblendingBalance (Label to display final balance)
Set Form1 as the startup form.
Press F5 or click Start to run the application.

# How It Works
The user enters a starting balance and number of months.
Press Calculate:
-The program loops through each month.
-Adds monthly interest (0.5%) to the balance.
-Shows each month’s ending balance in the ListBox.
The final balance is displayed in lblendingBalance.
Press Clear to reset inputs and results.
Press Exit to close the application.

# Project Structure
Form1.cs – main logic for calculations and UI interactions.
Form1.Designer.cs – UI layout, including textboxes, buttons, label, and listbox.

# Customization
Change INTEREST_RATE to simulate different interest rates.
Add input validation for negative numbers or maximum months.
Style the form for a more professional look (colors, fonts, etc.).

# Requirements
Windows OS
Visual Studio 2019 or later
.NET Framework 4.7+

# License
This project is free to use, modify, and share. Perfect for learning C# Windows Forms and basic finance calculations.
