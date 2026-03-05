<!-- ...existing code... -->
# Use SplashKit without installing (COS20007)

If you can't install SplashKit via the Canvas tutorial, copy the `lib` folder from this repository into your project.

## Prerequisites
- .NET SDK installed
- C# installed

## Quick setup

### Method 1 — Project in current directory
```bash
dotnet new console
cp -R lib ./
skm dotnet run
```

### Method 2 — Project in a subfolder
```bash
dotnet new console -o app
cp -R lib ./app
cd app
skm dotnet run
```

Replace `lib` with the path where you downloaded the folder if it's not in the repo root.