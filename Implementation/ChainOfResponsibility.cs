namespace Implementation;

public class ChainOfResponsibility
{
    public abstract class AnimalHandler
    {
        protected AnimalHandler? NextHandler { get; private set; }

        public void SetNext(AnimalHandler nextHandler)
        {
            NextHandler = nextHandler;
        }

        public virtual string HandleFood(string food) => NextHandler == null
            ? $"No animal eats the {food}."
            : NextHandler.HandleFood(food);
    }

    public class RabbitHandler : AnimalHandler
    {
        public override string HandleFood(string food)
        {
            return food == "carrot"
                ? $"Rabbit eats the {food}."
                : base.HandleFood(food);
        }
    }

    public class MonkeyHandler : AnimalHandler
    {
        public override string HandleFood(string food)
        {
            return food == "banana"
                ? $"Monkey eats the {food}."
                : base.HandleFood(food);
        }
    }

    public class LionHandler : AnimalHandler
    {
        public override string HandleFood(string food)
        {
            return food == "steak"
                ? $"Lion eats the {food}."
                : base.HandleFood(food);
        }
    }

    public class AnimalFeeder
    {
        private readonly AnimalHandler _firstHandler;

        public AnimalFeeder()
        {
            var rabbit = new RabbitHandler();
            var monkey = new MonkeyHandler();
            var lion = new LionHandler();

            rabbit.SetNext(monkey);
            monkey.SetNext(lion);

            _firstHandler = rabbit;
        }

        public string Feed(string food)
        {
            return _firstHandler.HandleFood(food);
        }
    }

}
