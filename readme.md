## Non-primitive Types

- We can create a class and use it by creating a new object
- Using the static keyword on a method we do not need to create a new object to use it.
- We can use the IDE to refactor class to a new file, keep in mind the namespace needs to be the same as where you are referencing the class.
- Without public keyword the class will not be accessible.
- If your class is in a different namespace, you will need to use the using at the top to import the class into your program.
- Struct is like a lightweight object, mostly we use classes.
- Use format string with placeholders to do string interpolation
- Use verbatim strings for things like a path so we dont need to escape all the charesters.
- Use Enums for things like options, we can use this to write cleaner code.

### To run this project:

- Clone the repository
- run `dotnet build`
- run `dotnet run`

### Useful Commands:

1. `dotnet --help` | Provides help for the SDK
2. `dotnet new gitignore` | Generates a new gitignore file
3. `dotnet run` | Runs app from root dir
4. `dotnet build` | Build the app from root dir
5. `dotnet new console --use-program-main` | Create the console app
