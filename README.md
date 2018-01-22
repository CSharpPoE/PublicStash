# PublicStashParser

Json to Object mapping for Path of Exile's Public Stash API.

### Prerequisites

* Visual Studio 2017 - Community edition

### Installing

1. Go to NuGet or open through visual studio
2. Search for CSharpPoe.PublicStash
3. Press Install (Through UI) or run 'Install-Package CSharpPoE.PublicStash -Version <Latest Stable Version Number>' in the package manager

## API

To use the API, start with adding PathOfExile namespace to your project. The API provides 3 methods:

GetAsync() // Does a GET to the path of exile public stash api with the latest change id as the query
GetAsync(String id) // Does a GET to the path of exile public stash api with id as the query. For manually entering the id, refer to the following site how the id is structured, and further information about the public stash api: [Path of Exile wiki](https://pathofexile.gamepedia.com/Public_stash_tab_API) 
GetLatestStashIdAsync() // Querying up to three popular community provided poe sites for the latest available change id. Poe.ninja is the default one. 

An example usage of this package can be seen below.
```
PublicStash publicStash = PublicStashAPI.GetAsync().Result; 
foreach (Stash stash in publicStash.stashes)
{
	foreach (Item item in stash.items)
	{
		// Apply logic here
	}
}
```

## Authors

* **Sebastian de Rzewuski** - *Initial work* - [Razkan](https://github.com/Razkan)

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

* [Grinding Gear Games](http://www.grindinggear.com) for making an awesome game!

