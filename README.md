# LethalPostersTool

A Windows desktop utility for creating custom poster mod assets for the game
Lethal Company. It replaces a repetitive manual workflow (image preparation and
mod folder structure) with a simple GUI.

## What it does

- Lets the user pick images and generates the poster/painting assets a
  LethalPosters-compatible mod expects.
- Produces the correct output folder structure so the result can be dropped
  straight into a mod profile.

## Tech

- C# on .NET 8
- Windows Forms
- Visual Studio solution (`LethalPostersCreator.sln`)

## Building

Open `LethalPostersCreator.sln` in Visual Studio 2022 (or run `dotnet build`)
and build the solution. The tool targets Windows.

## Background

I built this after noticing that preparing poster assets by hand was awkward
and error-prone. It is a small project, but it reflects how I like to work:
find a repetitive workflow, build a tool around it, and make it usable for
people who are not developers.
