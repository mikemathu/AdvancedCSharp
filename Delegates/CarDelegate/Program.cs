﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDelegate;

// First, make a Car object.
Car c1 = new Car("SlugBug", 100, 10);

// Now, tell the car which method to call
// when it wants to send us messages.
c1.RegisterWithCarEngine(
 new Car.CarEngineHandler(OnCarEngineEvent));
//c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent2));

// This time, hold onto the delegate object,
// so we can unregister later.
Car.CarEngineHandler handler2 =
 new Car.CarEngineHandler(OnCarEngineEvent2);
c1.RegisterWithCarEngine(handler2);

// Speed up (this will trigger th events).
Console.WriteLine("***** Speeding up *****");
for (int i = 0; i < 6; i++)
{
    c1.Accelerate(20);
}
Console.ReadLine();

// Unregister from the second handler.
c1.UnRegisterWithCarEngine(handler2);

// This is the target for incoming events.
static void OnCarEngineEvent(string msg)
{
    Console.WriteLine("\n*** Message From Car Object ***");
    Console.WriteLine("=> {0}", msg);
    Console.WriteLine("********************\n");
}

static void OnCarEngineEvent2(string msg)
{
    Console.WriteLine("=> {0}", msg.ToUpper());
}