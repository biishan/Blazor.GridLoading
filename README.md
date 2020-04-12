# Blazor.GridLoading 
![Build Status](https://dev.azure.com/biishan/Blazor.GridLoading/_apis/build/status/biishan.Blazor.GridLoading?branchName=master)
[![Nuget](https://img.shields.io/nuget/v/GridLoading.Blazor)](https://www.nuget.org/packages/GridLoading.Blazor/)

The purpose of this UI component library is to replace "loading..." message with a skeleton loader when data grid is being loaded.

## Add the NuGet package 

**Package Manager**
```bash
Install-Package GridLoading.Blazor 
```

**CLI**
```bash
dotnet add package GridLoading.Blazor
```
**.csproj**
```html
<PackageReference Include="GridLoading.Blazor" Version="1.0.0-preview1" />
```

## Reference the CSS Styling

Add the CSS to your application's index.html or _host.cshtml
```html
<link rel="stylesheet" href="_content/GridLoading.Blazor/styles.css" />
```

## Import the namespace

Add a reference to the namespace in your _Imports.razor or at the top of a page.

```html
@using Blazor.GridLoading
```

## Usage

This is to showcase how you can render ```<GridLoading />``` while data is being retrieved from an end point.

```html
@page "/fetchdata"
...
...

@if (forecasts == null)
{
    <GridLoading RowCount="5"
                 ColumnNames="@(new List<string> { "Date", "Temp. (C)", "Temp. (F)", "Summary" })"
                 AnimationType="AnimationType.Flash" />
}
else
{
    <!-- Rest of your HTML goes here. -->
}
```

### Optional

- Support Dark Mode
- Animation Duration (in seconds)
- Animation Iteration Count

```html
<GridLoading RowCount="5"
             ColumnNames="@(new List<string> { "Date", "Temp. (C)", "Temp. (F)", "Summary" })"
             AnimationType="AnimationType.Flash" IsDarkMode="true" AnimationDuration="3"
             AnimationIterationCount="1"/>
```

## Output

<img src="https://github.com/biishan/Blazor.GridLoading/blob/master/example.gif"/>
