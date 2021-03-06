# Version History

- 0.11
  - simulator
    - add holiday calendar, to provide accurate NextSimTime on last bar
  - data sources
    - fix issue w/ splice data source using open price in all fields
  - loader
    - add feature to disable loading algorithms from DLLs
  - showcase algorithms
	- separate glue logic from algorithms
    - update algorithms from Bensdorp's 30-Minute Stock Trader to closer match the book
	- add leveraged variants to Keller's DAA
	- add lazy portfolios
	- add Connors' Alpha Formula
  - indicators
    - improve robustnes of Markowitz CLA portfolios
- 0.10
  - loader
    - allow loading algorithms from entry-assembly
  - simulator
    - remove PendingOrders duplicate from SimCore
  - indicators
    - fix calculation of R2 as part of LinearRegression
  - data sources
    - avoid exceptions to speed up FRED load
    - add splice data source
    - add universe functionality
	- AddDataSource returns newly created DataSource
  - native reports
    - improve reports rendering: nicer plot colors, improved table layout, add feature to save as PNG and CSV
    - add scatter plots to SimpleChart and SimpleReport
    - improve SimpleReport template: improved metrics, annual return bar chart, and Monte-Carlo simulation
    - fix issue where SimpleReport did not show metrics
    - add ability to render stacked chart for target allocation
  - documentation
    - add QSG article for SimpleReport
  - build environment
    - update to MSVC 16.3.0 Preview 2.0
    - add single-click build script
    - make sure XML documentation is installed for TuringTrader.Simulator.dll
  - miscellaneous
	  - optional feature to pass algorithm parent into Plotter object
	- cleanup of showcase strategies
	  - closer track the original sources
	  - simplify customization
	  - standardize assets
- 0.9
  - 0.9b3 - August 02, 2019
    - fix issues on systems using non-U.S. localizations
    - fix incorrect data source descriptor for ‘fake options’
  - 0.9b2 - July 18, 2019
    - fix exceptions related to data caching
    - catch exceptions during optimization
    - simplify data source descriptors for SPX, VIX, 60/40
    - add the ability to do scatter plots
  - 0.9b1 - July 08, 2019
    - available as a binary distribution with standard Windows Setup
    - based on .NET Core 3
    - ability to run algorithms directly from source
    - C#-based output rendering
    - new data sources for FRED, Tiingo, and Yahoo
    - implicit data source descriptors
    - many UI improvements
    - rewritten quick start guide
- milestone 15 - May 14, 2019
