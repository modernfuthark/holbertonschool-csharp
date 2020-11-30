#!/usr/bin/env bash
# Builds a new C# project
dotnet new console -o 1-new_project
dotnet build 1-new_project/1-new_project.csproj
