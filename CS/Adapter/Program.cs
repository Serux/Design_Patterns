// See https://aka.ms/new-console-template for more information
using Adapter.src;

AmericanPlug ap = new AmericanPlug();
EuropeanPlug ep = new EuropeanPlug();
EuropeanSocket es = new EuropeanSocket();

// We can fit an European Plug in an european Socket:
Console.WriteLine($"European plug fits in european socket? : {es.fits(ep)}");

// But we cannot an American Plug
//Console.WriteLine(es.fits(ap));

// We can create an adapter
AmericanToEuropeanPlugAdapter atepa = new AmericanToEuropeanPlugAdapter(ap);
// Now we can fit the american plug in the european Socket by the adapter:
Console.WriteLine($"American plug fits in european socket using adapter? : {es.fits(atepa)}");

// but the first plug originaly is european
Console.WriteLine($"Original pin tipe of european plug? : {ep.originalPinType()}");
// and the adapter, is american
Console.WriteLine($"Original pin tipe of adapter plug? : {atepa.originalPinType()}");



