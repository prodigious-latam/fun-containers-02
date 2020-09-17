# Running the API by itself

```
docker build -t aspnetapp .
docker run -it --rm -p 5000:80 --name aspnetcore_sample aspnetapp
```

Or natively:
```
dotnet run
```

Browse to [http://localhost:5000/WeatherForecast](http://localhost:5000/WeatherForecast)