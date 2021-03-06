using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Delegates.Patterns.Adapter;
using Delegates.Patterns.Builder;
using Delegates.Patterns.ChainOfResponsibility;
using Delegates.Patterns.Command;
using Delegates.Patterns.Composite;
using Delegates.Patterns.Decorator;
using Delegates.Patterns.Factory;
using Delegates.Patterns.Iteratror;
using Delegates.Patterns.Observer;
using Delegates.Patterns.Prototype;
using Delegates.Patterns.Singleton;
using Delegates.Patterns.State;
using Delegates.Patterns.Template;
using Delegates.Patterns.Vistor;

namespace Delegates
{
    class Program
    {
        private static Func<string, IEnumerable<char>> TextAdjuster;
        
        static void Main(string[] args)
        {
            /*
            string name = "David Harrington";
            
            Console.WriteLine(ConsoleEnumReader(Processor(Reverser, name)));
            Console.WriteLine(ConsoleEnumReader(Processor(UpperMaker, name)));
            TextAdjuster = LowerMaker;
            Console.WriteLine(ConsoleEnumReader(Processor(TextAdjuster, name)));
            Console.WriteLine(ConsoleEnumReader(Processor(s => s.Reverse(), name)));

            var factoryMaker = new VehicleFactoryMaker();
            var factory = factoryMaker.GetFactory("van");

            Vehicle van = factory.Build();

            RefrigeratedVan fridgeVan = new RefrigeratedVan(van as Van);
            
            Animal dog = new Dog();
            Animal bird = new Bird();
            Animal parrot = new Parrot();

            List<Animal> animals = new List<Animal>() {dog, bird, parrot};

            foreach (var animal in animals)
            {
                Console.WriteLine(
                    $"Name: {animal.Name}, {animal.FlyingBehaviour.Action()},{animal.WalkingBehaviour.Action()}, {animal.TalkingBehaviour.Action()}");
            }
            
            */

            ISubject subject = new Subject();
            IObserver tradingObserver = new TradingObserver();
            IObserver watchingObserver = new WatchingObserver();
            
            subject.RegisterObserver(tradingObserver);
            subject.RegisterObserver(watchingObserver);
            
            subject.UpdateObservers();

            subject.UnregisterObserver(tradingObserver);
            subject.UpdateObservers();

            Ship ufoShip = new EnemyShipFactory().Create("ufo");
            Ship rocketShip = new EnemyShipFactory().Create("rocket");

            OnlyOne one = OnlyOne.Instance;
            OnlyOne two = OnlyOne.Instance;
            OnlyOne three = OnlyOne.Instance;
            
            Console.WriteLine($"{one.GetHashCode()}, {one.Born}");
            Console.WriteLine($"{two.GetHashCode()}, {two.Born}");
            Console.WriteLine($"{three.GetHashCode()}, {three.Born}");

            IVehicleBuilder builder = new CarBuilder();
            builder.BuildEngine("1600cc");
            builder.BuildSunroof("Smoked");
            builder.BuildWheels("Alloys Black");
            builder.BuildSteeringWheel("Leather");

            var car = builder.Vehicle;
            
            builder = new VanBuilder();
            builder.BuildEngine("2500cc");
            builder.BuildSunroof("Clear");
            builder.BuildWheels("Steel Black");
            builder.BuildSteeringWheel("Heated");

            var van = builder.Vehicle;
            
            Console.WriteLine(car.ToString());
            Console.WriteLine(van.ToString());

            var sheep = new Sheep();
            var goat = new Goat();

            var sheepClone = new PrototypeOrchestrator().GetClone(sheep);
            var goatClone = new PrototypeOrchestrator().GetClone(goat);
            
            Console.WriteLine($"{sheep.Name}, {sheep.GetHashCode()}");
            Console.WriteLine($"{sheepClone.Name}, {sheepClone.GetHashCode()}"); 
            Console.WriteLine($"{goat.Name}, {goat.GetHashCode()}");
            Console.WriteLine($"{goatClone.Name}, {goatClone.GetHashCode()}");

            MenuController textFileController = new MenuController(new TextDocument());
            
            textFileController.NewCommand.Execute(null);
            textFileController.SaveCommand.Execute(null);
            textFileController.SaveAsCommand.Execute(null);
            textFileController.DeleteCommand.Execute(null);
            
            MenuController drawingFileController = new MenuController(new DrawingDocument());
            
            drawingFileController.NewCommand.Execute(null);
            drawingFileController.SaveCommand.Execute(null);
            drawingFileController.SaveAsCommand.Execute(null);
            drawingFileController.DeleteCommand.Execute(null);

            IPersonGenerator generator = new NewPersonGenerator();
            var newPerson = generator.Create("David", "Harrington", Gender.Male);
            generator = new LegacyPersonGenerator();
            generator.Create("David", "Harrington", Gender.Male);
            LegacyPerson legacyPerson  = ((ILegacyPersonRetriever) generator).Get();

            newPerson = legacyPerson.ToPerson();
            
            Console.WriteLine(newPerson);
            Console.WriteLine(legacyPerson);

            dynamic p = newPerson;
            
            Console.WriteLine(p.FirstName);

            var standardSandwich = new StandardSandwich();
            standardSandwich.MakeSandwich();

            var drySandwich = new DrySandwich();
            drySandwich.MakeSandwich();

            TestIterations iterations = new TestIterations();
            iterations.Test();

            IOrganisationUnit company = new Organisation() { Name = "IBM" };
            company.AddNew(new Organisation() { Name = "Marketing" });
            company.AddNew(new Organisation() { Name = "Finance" });
            company.AddNew(new Organisation() { Name = "Technology" });
            company.AddNew(new Organisation() { Name = "Sales" });

            var targetPizza = new Pepperoni(new Mozarella(new Mushroom(new PlainPizza())));
            
            IPizza  pizza = new PlainPizza();

            Console.WriteLine($"1 # Descr: {pizza.Description}, Cost: {pizza.Cost}");

            pizza = new PlainPizza();
            pizza.AddTopping(new Mozarella());
            pizza.AddTopping(new Mushroom());
            pizza.AddTopping(new Pepperoni());
            pizza.AddTopping(new Pepperoni());

            pizza.TakeFromInventory(2);
            pizza.SetTaxStatus(TaxStatus.Exempt);
            
            Console.WriteLine($"2 # Descr: {pizza.Description}, Cost: {pizza.Cost}, Tax Status: {pizza.TaxStatus}");
            Console.WriteLine($"Target # Descr: {targetPizza.Description}, Cost: {targetPizza.Cost}");

            var fxTrade = new FxTrade { Value = 1234.56d };
            var eqTrade = new EquityTrade() { Value = 1234.56d };
            var stampDutyVisitor = new StampDutyVisitor();

            Console.WriteLine($"FxTrade: {fxTrade.Value}, Duty:{fxTrade.Duty}  Value: {fxTrade.Accept(stampDutyVisitor)}");
            Console.WriteLine($"Equity Trade: {eqTrade.Value}, Duty:{eqTrade.Duty}, Value:  {eqTrade.Accept(stampDutyVisitor)}");

            var atm = new Atm();

            Console.WriteLine(atm.EnterPin(1234));
            Console.WriteLine(atm.InsertCard());
            Console.WriteLine(atm.EnterPin(1234));
            Console.WriteLine(atm.EnterPin(123456));
            Console.WriteLine(atm.RequestCash(125));
            Console.WriteLine(atm.WithdrawCard());
            Console.WriteLine(atm.State);
            atm.State = StateBehaviourFactory.Get(StateBehaviourType.OutOfMoney);
            Console.WriteLine(atm.EnterPin(123456));
            Console.WriteLine(atm.InsertCard());
            atm.State = StateBehaviourFactory.Get(StateBehaviourType.NoCard);
            Console.WriteLine(atm.InsertCard());
            Console.WriteLine(atm.EnterPin(123456));

            Console.WriteLine(atm.RequestCash(125));
            Console.WriteLine(atm.WithdrawCard());

            ITradeType tradeType = new TradeType2();

            var processor = new TradeTypeProcessorType1()
            {
                NextProcessor = new TradeTypeProcessorType2()
                {
                    NextProcessor = new TradeTypeProcessorType3()
                }
            };
            
            Console.WriteLine(processor.Process(tradeType).ToString());
            
            tradeType = new TradeType3();
            
            Console.WriteLine(processor.Process(tradeType).ToString());
            
            tradeType = new TradeType1();
            
            Console.WriteLine(processor.Process(tradeType).ToString()); 
            
            tradeType = new TradeTypeNone();

            try
            {
                Console.WriteLine(processor.Process(tradeType).ToString());
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        private static string ConsoleEnumReader(IEnumerable<char> payload)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in payload)
            {
                sb.Append(c);
            }

            return sb.ToString();
        }
        private static IEnumerable<char> Processor(Func<string, IEnumerable<char>> func, string text)
        {
            return func(text);
        }

        private static IEnumerable<char> Reverser(string textIn)
        {
            return textIn.Reverse();
        }

        private static IEnumerable<char> UpperMaker(string textIn)
        {
            return textIn.ToUpper().ToCharArray();
        } 
        
        private static IEnumerable<char> LowerMaker(string textIn)
        {
            return textIn.ToLower().ToCharArray();
        }
    }
}