// Streamlined Program.cs: 
// The template for the controller-based web API wires up the controllers 
// using the AddControllers method. In addition, it wires up Swagger to provide OpenAPI support. 
// Minimal APIs don't have this wiring by default, though you can add Swagger if you wish.
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    // add my own routes
});


// Routing looks a little different: 
// The routing looks slightly different compared to a 
// controller-based web API. In a web API, for routing you write code as shown:
app.MapGet("/todos", await (TodoDb db) => db.Todos.ToListAsync());
app.MapPost("/todos", await (Todo todo) => {});
app.MapPut("/todos", (Todo todo) => {});
app.MapDelete("/todos/{id}", (int id) => {});

//API code
var builder = WebApplication.CreateBuilder(args);   
var app = builder.Build();  //Application instance
app.MapGet("/", () => "Hello World!");
app.Run();

/*The builder has a Services property. By using the Services property, you can add features like 
 CORS, Entity Framework, or Swagger. Here's an example: */
builder.Services.AddCors(options => {});

/*In the Services property, you tell the API that here's a capability to use. Conversely, the 
app instance is used to actually use it. So you can use the app instance to set up routing: */
app.MapGet("/", () => "Hello World!");
app.UseCors("some unique string"); //Instance of Middleware by app.

/*Middleware is usually code that intercepts the request and carries out checks like checking for 
authentication or ensuring the client is allowed to perform this operation according to CORS.  */

/* If you've used earlier versions of .NET, you'll notice the lack of using statements. With .NET 6, 
the compiler figures out using statements for you. It's not something you need to care about. */
