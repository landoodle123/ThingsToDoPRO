# Welcome to ThingsToDoPRO
This documentation has two parts, one for development and one for users. If you would like to see one section or the other, they will be marked with headings.

# Section One: Users
Welcome to TTDP! We are glad that you chose our to do list over some others. To get started using the app, install it via our installer file. Once it is installed, you run the file. It will give you an error, but that is to be expected. Press OK and then continue with the app.
**Some features of the app include:**
 - Sophisticated date and time system
 - Notifications when your task is due
 - Easy to run on low-end machines
 - Tasklists save when the app is closed (note that you cannot recieve notifications when the app is closed.)
 - Issue solving if needed at any point

# Section Two: Developers
Thank you for choosing to work with ThingsToDoPRO for your open source development! I am sorry in advance for my garbage code. ThingsToDoPRO is a very simple Windows Forms application, and the code can be broken down in just a few pieces:
 - (Form1.cs and Form1.Designer.cs) Intialising the components
 - (Form1.cs) A button that saves the tasks, date, and time to the list
 - (Form1.cs) A feature where it saves tasks to the files and loads upon the app starting
 - (Form1.cs) A change background method where when you change the background it saves into the text file
 - (Form1.cs) A task list with buttons for deleting and clearing tasks, as well as checkboxes for each task to mark them as completed