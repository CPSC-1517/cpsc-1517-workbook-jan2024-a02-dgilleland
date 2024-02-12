# Blazor 8 - Empty Template

For setup in this

- [ ] Create a Blazor 8 web application (empty template - notice the `-e`)

    ```powershell
    # Run from the root of your workbook
    dotnet new blazor -o src/007/Website -n WebApp -e
    dotnet new sln -o src/007 -n EmptyBlazorDemo
    cd src/007
    dotnet sln add Website/WebApp.csproj
    cd Website
    ```

- [ ] Run the blazor website (in watch mode)

    ```powershell
    dotnet watch
    ```

----

## Comparing Blazor 8 Templates

The default Blazor template comes with some sample code to help newcomers learn about basic aspects of a Blazor-based web application. Seasoned developers may choose to start with the *empty template* (the `-e` option) so that they can have more control over what is (and *isn't*) in their project.

The following table shows the commands to run to get a listing of what files are created for the default and the empty Blazor 8 templates.

| Blazor 8 | Blazor 8 Empty |
|---|---|
| `dotnet new blazor --dry-run -n WebApp -o Blazor` | `dotnet new blazor --dry-run -n WebApp -o Blazor -e` |

### 'Bout Bootstrap

The default template uses Bootstrap for its layout and styling. While great in its day, Bootstrap is now considered as a "heavy" legacy layout approach. Modern designers use CSS Grid for layout along with other CSS advances to produce stunning and flexible layouts with minimal effort.

## Starting With a Clean Slate

Run `dotnet new blazor -n WebApp -o Website -e` in the terminal to start up a website with the empty template. Then add a solution file (`dotnet new sln -n LearnBlazor -o .`) that will reference the web app (`dotnet sln add Website/WebApp.csproj`).

### No-Class (*Classless*) Styling

**"No-class"** styling brings the benefit of allowing your HTML to be "clean" and focused on the *content* of your website/application. They say "Content is King", but that's only lip-service if you wind up butchering your HTML with CSS classes and nesting `<div>`s just to get it to "look good".

> For a good look at various no-class stylesheets, take a look at the Sep '23 article [**"Comparing classless CSS frameworks"**](https://blog.logrocket.com/comparing-classless-css-frameworks/) by Shalitha Suranga. An older list that includes other classless frameworks can be seen in the article ["No-Class CSS Frameworks"](https://css-tricks.com/no-class-css-frameworks/) (May, 2020).

#### [Pico CSS](https://picocss.com/)

Add the following line to the `<head>` of the `App.razor` component. ***NOTE:** the portions that read `@@picocss` and `pico@@1` each have an extra `@` because of how Razor pages (the foundation for Blazor) use that as a way of identifying variables; the double `@@` "escapes" so that a single `@` symbol will appear in the rendered HTML.*

```html
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/@@picocss/pico@@1/css/pico.min.css">
``` 

Alternatively, use the following for the fluid viewport of [classless Pico CSS](https://picocss.com/docs/classless.html).

```html
// Fluid viewport
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/@picocss/pico@1/css/pico.fluid.classless.min.css">
```

## A Little Bit of Bling

### Adding a FavIcon

Put your desired favicon in the `wwwroot` folder, and add the following to the `<head>` of your `App.razor` file. You may have to adjust the `type` and `href` portions to match the kind of image you are using as your favicon (the sample below uses a png file: ![favicon](./Website/wwwroot/favicon.png)).

```html
<link rel="icon" type="image/png" href="/favicon.png">
```

----


### Credits

- **FavIcon:** - ![](./_move_to_wwwroot/icons8-internet-laces-16.png) [Internet](https://icons8.com/icon/eTJ3Q9REJ1nH/internet) icon by [Icons8](https://icons8.com)
