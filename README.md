# Desktop app

This is a Windows Forms application developed using Visual Basic .NET. The application consists of several forms that provide functionalities such as toggling a stopwatch, navigating through submissions, and accepting user inputs.

## Features

- **Form1**: Initial form for basic input and navigation.
- **Form2**: Contains a stopwatch with start, stop, and toggle functionalities.
- **Form3**: Displays submissions retrieved from a local server and allows navigation through them using keyboard shortcuts.

## Forms Overview

### Form1

- **Purpose**: Initial form for basic input and navigation.
- **Components**: 
  - Various input fields and buttons for user interaction.

### Form2

- **Purpose**: Contains a stopwatch with start, stop, and toggle functionalities.
- **Components**:
  - `lbltoggle`: Displays the elapsed time.
  - `btntogglex`: Button to toggle the stopwatch.
  - `btnsubmit3`: Button to submit data including the stopwatch time.
- **Keyboard Shortcuts**:
  - `Ctrl + T`: Toggle the stopwatch.
  - `Ctrl + R`: Start the stopwatch.
  - `Ctrl + P`: Stop the stopwatch.
  - `Ctrl + S`: Submit the data.

### Form3

- **Purpose**: Displays submissions retrieved from a local server and allows navigation through them.
- **Components**:
  - `TextBox1`, `email`, `phone`, `link`, `txtstp`: Fields to display submission details.
  - `nxt`: Button to display the next submission.
  - `previous`: Button to display the previous submission.
- **Keyboard Shortcuts**:
  - `Ctrl + N`: Move to the next submission.
  - `Ctrl + P`: Move to the previous submission.

## Submissions Retrieval

Submissions are retrieved from a local server running at `http://localhost:3000/submissions`. Make sure the server is running and accessible when using the application.

Backend server repo link:- https://github.com/AaryanPalve5/Basic-Database
