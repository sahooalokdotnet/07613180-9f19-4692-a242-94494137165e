# 07613180-9f19-4692-a242-94494137165e
Coding Test: Find longest increasing subsequence.

Important !!!
=============

Please install dotnet sdk 10.0.0.

Docker Setup
=============
DOCKER BUILD : docker build -t longest-increasing-subsequence .
DOCKER RUN : docker run -it --rm longest-increasing-subsequence
INPUT : 10 5 8 3 9 4 12


BUILD/RUN On Local:
==================
Build: dotnet build
Run: dotnet run
Test: dotnet test

Code Coverage Reporting:
========================
Run tests with coverage collection:

	dotnet test MySolution.slnx --collect:"XPlat Code Coverage" --results-directory ./TestResults

Generate an HTML report from the collected Cobertura files:

	dotnet tool install --global dotnet-reportgenerator-globaltool
	reportgenerator -reports:"TestResults/**/coverage.cobertura.xml" -targetdir:"CodeCoverage" -reporttypes:"Html;Cobertura"

Open `CodeCoverage/index.html` to view the report. Generated `TestResults/` and `CodeCoverage/` directories are ignored by Git.