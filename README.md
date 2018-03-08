# JsonSerializationBlockingCalls

This repo contains repro for showing blocking calls (with help of  [Ben.BlockingDetector](https://github.com/benaadams/Ben.BlockingDetector))  in Kestrel while serializing JSON that is bigger than ~64kb.

###Starting application
There are 2 profiles for application to run. 
- One without turning on gzip where you can see blocking calls 
 `dotnet run --launch-profile Gzip`
 
- One with turning on gzip where blocking calls disappear
`dotnet run --launch-profile NoGzip`

###Available endpoints
/api/values/{size}

Size define json response size in KB. Avalaible size values:
 - 16
 - 32
 - 64
 - 128
 - 256
 - 1024
