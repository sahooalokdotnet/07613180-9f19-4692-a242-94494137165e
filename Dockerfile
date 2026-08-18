FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

WORKDIR /src

COPY src/LongestIncreasingSubsequence/LongestIncreasingSubsequence.csproj src/LongestIncreasingSubsequence/
COPY src/LongestIncreasingSubsequence.App/LongestIncreasingSubsequence.App.csproj src/LongestIncreasingSubsequence.App/

RUN dotnet restore src/LongestIncreasingSubsequence.App/LongestIncreasingSubsequence.App.csproj

COPY src/ src/

RUN dotnet publish \
    src/LongestIncreasingSubsequence.App/LongestIncreasingSubsequence.App.csproj \
    -c Release \
    -o /app/publish \
    --no-restore


FROM mcr.microsoft.com/dotnet/runtime:10.0 AS final

WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "LongestIncreasingSubsequence.App.dll"]