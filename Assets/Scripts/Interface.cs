// //Interface for the model factorty
// public interface IBirdModelFactory
// {
//     IBirdModel Model { get; }
// }
// //Implementation of the model factory
// public class BirdModelFactory : IBirdModelFactory
// {
//     public IBirdModel Model { get; private set;}

//     //Tao model
//     public BirdModelFactory()
//     {
// 		Model = new Model();
//     }
// }

// //Interface for the view factorty
// public interface IBirdViewFactory
// {
//     IBirdView View { get; }
// }
// //Implementation of the view factory
// public class BirdViewFactory : IBirdViewFactory
// {
//     public IBirdView View { get; private set;}

//     //Khoi tao view
//     public BirdViewFactory()
//     {
// 		View = instance.GetComponent<IEnemyView>();
//     }
// }
// //Interface for the controller factorty
// public interface IBirdControllerFactory
// {
//     IBirdController Controller { get; }
// }
// //Implementation of the controller factory
// public class BirdControllerFactory : IBirdControllerFactory
// {
//     public IBirdController Controller { get; private set ;}

//     //Create just the controller
//     public BirdControllerFactory(IBirdModel model, IBirdView view)
//     {
//         Controller = new BirdController(model, view);
//     }
//     //Khoi tao controller, view, controller
//     public BirdControllerFactory()
//         : this(new Model(), new View())
//     {
//     }
// }


 