<img src="https://i.imgur.com/yqIN5FX.png" width="300px" />

## Furniture Factory - Workshop

The Furniture Factory is already implemented for you. You are provided with the author solution for this task, you now need to just... well, refactor it a little bit.

## General requirements

**There are multiple correct ways to solve this task.** In general, just try to make the code better, easier to read and easier to use. **Don't go** over your head by implementing some very complex architecture and try not to overabstract the project. Before you do something, make sure you have a **very clear** answer to the "Why" question. The requirements for this workshop are pretty much the same as the ones for your teamwork and are somewhat similar to the exam format. Define and implement the following:

- The **SOLID** principles (where applicable)
  - Single responsibility
  - Open/closed
  - Liskov substitution
  - Interface segregation
  - Dependency inversion

- Dependency inversion container (using **Autofac**)
  - Favor composition over inheritance
  - Introduce object lifetime management
  - Introduce convention based binding

- Unit tests
  - Unisolated tests will be looked upon as **invalid**!
  - Introduce unit tests for:
    - **Company** class:
      - **Company.Add()** method
      - **Company.Find()** method
      - **Company.Catalog()** method
    - **FurnitureManufacturerEngine** class:
      - **FurnitureManufacturerEngine.ProcessCommands()** method
    - You can, of course, test the other classes as well, if you want, after finishing with these.

## Recap

But let's first do a quick recap of what this software is all about. A furniture manufacturer keeps track of their companies and furniture: tables and chairs.

- Each furniture piece has **model, material, price in dollars, and height in meters**.
- Each table has **length and width in meters**.
- Chairs are three types: **normal, adjustable and convertible**.
  - Each chair has number of legs.
  - Each adjustable chair can adjust its height.
  - Each convertible chair can convert its state and be easily movable.
- Each company has **name, registration number and catalog of furniture**. Companies can add or remove furniture to their catalogs. Companies can find furniture by model. Companies can show catalogs of all furniture they offer.

Current implemented commands the engine supports are:

- **CreateTable (model) (material) (price) (height) (length) (width)** – creates a table with given model, material, price, height, length and width. Duplicate models are not allowed. As a result the command returns “Table (model) created”.
- **CreateChair (model) (material) (price) (height) (legs)** – creates a chair by given model, material, price, height, legs and type. Duplicate models are not allowed. As a result the command returns “Chair (model) created”.
- **CreateCompany (name) (registration number)** – adds a company with given name and registration number. Duplicate names are not allowed. As a result the command returns “Company (name) created”.
- **AddFurnitureToCompany (company name) (furniture model)** – searches for furniture and adds it to an existing company’s catalog. As a result the command returns “Furniture (furniture model) added to company (company name)”.
- **RemoveFurnitureFromCompany (company name) (furniture model)** – searches for furniture and removes it from an existing company’s catalog. As a result the command returns “Furniture (furniture model) removed from company (company name)”.
- **FindFurnitureFromCompany (company name) (furniture model)** – searches for furniture in an existing company’s catalog. If found the engine prints the furniture’s ToString() method.
- **ShowCompanyCatalog (company name)** – searches for a company and invokes it’s Catalog() method.


**All commands return appropriate success messages. In case of invalid operation or error, the engine returns appropriate error messages.**


## Sample Input

```md
CreateCompany FurnitureTelerik 1234567890
ShowCompanyCatalog FurnitureTelerik
CreateTable SmallTable wooden 123.4 0.50 0.45 0.65
CreateChair TestChair leather 99.99 1.20 5
CreateChair MyChair leather 111.56 0.80 4
CreateChair NewChair plastic 80.00 1.00 3
ShowCompanyCatalog FurnitureTelerik
AddFurnitureToCompany FurnitureTelerik SmallTable
AddFurnitureToCompany FurnitureTelerik TestChair
AddFurnitureToCompany FurnitureTelerik MyChair
AddFurnitureToCompany FurnitureTelerik NewChair
ShowCompanyCatalog FurnitureTelerik
RemoveFurnitureFromCompany FurnitureTelerik NewChair
ShowCompanyCatalog FurnitureTelerik
FindFurnitureFromCompany FurnitureTelerik MyChair
FindFurnitureFromCompany FurnitureTelerik NewChair
RemoveFurnitureFromCompany FurnitureTelerik MyChair
RemoveFurnitureFromCompany FurnitureTelerik SmallTable
ShowCompanyCatalog FurnitureTelerik
```

## Sample Output

```md
Company FurnitureTelerik created
FurnitureTelerik - 1234567890 - no furnitures
Table SmallTable created
Chair TestChair created
Chair MyChair created
Chair NewChair created
FurnitureTelerik - 1234567890 - no furnitures
Furniture SmallTable added to company FurnitureTelerik
Furniture TestChair added to company FurnitureTelerik
Furniture MyChair added to company FurnitureTelerik
Furniture NewChair added to company FurnitureTelerik
FurnitureTelerik - 1234567890 - 4 furnitures
Type: Chair, Model: NewChair, Material: Plastic, Price: 80.00, Height: 1.00, Legs: 3
Type: Chair, Model: TestChair, Material: Leather, Price: 99.99, Height: 1.20, Legs: 5
Type: Chair, Model: MyChair, Material: Leather, Price: 111.56, Height: 0.80, Legs: 4
Type: Table, Model: SmallTable, Material: Wooden, Price: 123.4, Height: 0.50, Length: 0.45, Width: 0.65, Area: 0.2925
Furniture NewChair removed from company FurnitureTelerik
FurnitureTelerik - 1234567890 - 3 furnitures
Type: Chair, Model: TestChair, Material: Leather, Price: 99.99, Height: 1.20, Legs: 5
Type: Chair, Model: MyChair, Material: Leather, Price: 111.56, Height: 0.80, Legs: 4
Type: Table, Model: SmallTable, Material: Wooden, Price: 123.4, Height: 0.50, Length: 0.45, Width: 0.65, Area: 0.2925
Type: Chair, Model: MyChair, Material: Leather, Price: 111.56, Height: 0.80, Legs: 4
Furniture NewChair not found
Furniture MyChair removed from company FurnitureTelerik
Furniture SmallTable removed from company FurnitureTelerik
FurnitureTelerik - 1234567890 - 1 furniture
Type: Chair, Model: TestChair, Material: Leather, Price: 99.99, Height: 1.20, Legs: 5
```

## Guide overview

**IMPORTANT NOTE** - You can use the author solution to help yourself thoughout this task. Note that the author solution contains more advanced ways of using Autofac. You do not have to use them as well, they are there to simply show that there's another way of doing things. The author solution is not fully SOLID nor fully unit tested. It is meant to be a guideline for you to follow, not an end goal. The quality of it's code is sufficient enough, but if you want, you can improve it even more for the sake of practice. :)

**HINT** - Always run the sample input test after every change you introduce, in order to reduce the risk of bugs.

**HINT** - It is a good idea to create a local repository. Try to commit to it as often as possible. Use easy to understand commit messages and write commit descriptions, if you find that necessary.

1. Install AutoFac from NuGet
1. Get rid of all static classes and members (and the shitty singleton shit)
1. Register dependencies in an AutoFac configuration class (configure singletons where needed!)
1. Split bigger classes (like the engine) into smaller ones (SRP)
1. Introduce commands as seperate classes and bind them to AutoFac (you can use Marto's slick way)
1. Write unit tests

## Step by step guide

- Install AutoFac from NuGet
- Setup a **sperate config class** that will handle autofac related configurations. It could look something something like this:

```cs
internal sealed class AutofacConfig
{
    public IContainer Build()
    {
        var containerBuilder = new ContainerBuilder();

        this.RegisterConvention(containerBuilder);
        this.RegisterCoreComponents(containerBuilder);

        return containerBuilder.Build();
    }

    private void RegisterConvention(ContainerBuilder builder)
    {
        var coreAssembly = Assembly.GetExecutingAssembly();

        // Modify this to include exceptional cases and such... (if needed)
        builder.RegisterAssemblyTypes(coreAssembly)
                .AsImplementedInterfaces();
    }

    private void RegisterCoreComponents(ContainerBuilder builder)
    {
        builder.RegisterType<FurnitureManufacturerEngine>().As<IEngine>().SingleInstance();
        // Write the rest of your bindings... (if needed)
    }
}
```

**HINT** - Copy/pasing code is fine, as long as you **truely understand what it's doing and why**. Take some time to think about why did I implement that class as **sealed** and why did I introduce several methods into it.

- **[Advanced]** You could also prevent the Build method from being **called twice**. (See author solution)
- Use it in the startup class, something like this:

```cs
public sealed class Startup
{
    public static void Main()
    {
        var containerConfig = new AutofacConfig();
        var container = containerConfig.Build();

        var engine = scope.Resolve<IEngine>();
        engine.Start();
    }
}
```

- Let's fix up the engine a little bit. Pull each command into a **seperate class**!
- You could introduce a **seperate class** to hold these dictionaries from the Engine

**HINT** - Do those collections really need to be dictionaries? What benefits do you get from saving them as such? _(answer: yes and no, depending on what you are trying to achieve)_

- **[Advanced]** Encapsulate those dictionaries even more by introducing methods for **add/remove** _(Look up DataStore inside author solution)_
- You could use an interface for named based binding, something like:

```cs
public interface ICommand
{
    string Execute(IList<string> parameters);
}
```

- Note that there already is an ICommand interface and a command class. You could either use those or refactor and impelement them in a similar to the OOP exam way.
- **[Advanced]** Instead of using the switch case statement, use Autofac's name based invocation. You can see more information about this in Marto's live demo video from Friday.

- Start with the Company tests, as they are a bit easier.
- For the Engine tests, don't expose the private methods, test thought the public Start method, which means that you need to setup the Renderer to return appropriate Input().

**HINT** - Do not try to mock collections. They are BCL objects and mocking is not needed, it only introduced unwanted complexity.

**HINT** - You cannot validate against non-mock object, therefore you cannot validate against collections. Instead, just check if a given collection contains a given object.

## For the curious ones

- **[Very Advanced]** You can still use reflection to get all the commands that are available in your assebly and bind them inside Autofac. You can see this implemented in **AutofacConfig.RegisterDynamicCommands()** method in the author solution. There are some comments inside to explain what's going on.

- **[Very Advanced]** You could use a dynamic casting and register a dynamic factory that would return a given command bases on it's name, without actually implementing that factory. See the **AutofacConfig.RegisterDynamicFactory()** method in the author solution, if you are interested. **Keep in mind that this is indeed a "hack"** and it's not recommended to implement it this way, as you are binding to an instance that **does not yet exist** at the time of the container being built. (that being the this.Container property)
