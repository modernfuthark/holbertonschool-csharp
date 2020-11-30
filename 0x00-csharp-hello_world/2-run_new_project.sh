#!/usr/bin/env bash
# Initializes, builds, and runs a new C# project.
dotnet new console -o 2-new_project
dotnet build 2-new_project/2-new_project.csproj
dotnet run -p 2-new_project
