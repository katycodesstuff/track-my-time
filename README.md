# track-my-time

This is a simple WinForms app written using .NET 6 in C#.

I created it to simply track how many hours I have accrued per week, and also as a chance to look at some .NET 6 features, plus a reason to upload some C# to my GitHub!

This was created in around 2-3 hours.

## Features ##

- Type in how many hours you worked this week e.g. 41, and choose the date for the week you are submitting, to view the accrued hours total (where the workweek is set to 40hrs).
- View when the number was last updated.
- Enter the time either in decimal format e.g. 40.5, or in HH:MM format e.g. 40:30
- You cannot enter multiple values for the same week
- Error handling shows a message if validation does not pass
- Data is stored in a plaintext file
- Data saves on exit

## Future enhancements ##

- Unit testing
- Use DI
- Allow deletion of last entered date
- Allow customisation of your weekly hours
- Save every time value is added
- Add ability to subtract TOIL taken
