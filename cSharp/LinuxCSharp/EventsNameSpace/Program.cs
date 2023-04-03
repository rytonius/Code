using static System.Console;
using EventsNameSpace;
using EventsNameSpace2;

publisher incrementer = new publisher();
Suscriber dozensCounter = new Suscriber(incrementer);

incrementer.doCount(100);
WriteLine("incrememnter: Number of dozens = {0}", dozensCounter.DozensCount);

EHPublisher EHP = new EHPublisher();
EHSuscriber EHS = new EHSuscriber(EHP);

EHP.DoCount(100);
WriteLine("EHP: Number of dozens = {0}", EHS.DozensCount);
EventsNameCustom.Program.Main();

AnotherEvent.DoIt DOIT = new AnotherEvent.DoIt();
//DOIT.RunIt();  // only run this in a terminal if you want to check out this .cs file


SimpleEvents.DoIt SC = new SimpleEvents.DoIt();
SC.RunIt();

EventsDude.Program EDD = new EventsDude.Program();
EDD.Main();

WriteLine("\nExtendingEventArgs\n");
ExtendingEventArgs.Program EEAP = new ExtendingEventArgs.Program();
EEAP.Main();

WriteLine("\nRemovingEventArgs\n");
RemovingEventhandlers.Program REHP = new RemovingEventhandlers.Program();
REHP.Main();