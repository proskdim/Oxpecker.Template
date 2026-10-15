open Microsoft.AspNetCore.Builder
open Microsoft.Extensions.DependencyInjection
open Oxpecker
open Oxpecker.ViewEngine
open Oxpecker.Htmx

let indexPage =
    html() {
        head() {
            title() { "Oxpecker + HTMX" }
            script(src="https://cdn.jsdelivr.net/npm/htmx.org@4.0.0", crossorigin="anonymous")
        }
        body() {
            h1() { "Basic htmx example" }
            button().hxGet("/message") { "Click me" }
        }
    }

let endpoints = [
    route "/" <| htmlView indexPage
    route "/message" <| text "Hello HTMX"
]

[<EntryPoint>]
let main args =
    let builder = WebApplication.CreateBuilder(args)
    builder.Services.AddRouting().AddOxpecker() |> ignore
    let app = builder.Build()
    app.UseRouting()
        .Use(Default.exceptionMiddleware)
        .UseOxpecker(endpoints)
        .Run(Default.notFoundHandler)
    app.Run()
    0 // Exit code