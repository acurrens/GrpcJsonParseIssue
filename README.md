# GrpcJsonParseIssue
Grpc demo project illustrating failure of "ignore unknown fields" when parsing json

Demo project to illustrate the issue with GRPC parsing json strings with: Parser.WithDiscardUnknownFields(true);

Seems the same as: https://github.com/grpc/grpc-dotnet/issues/1114


![alt text](https://github.com/acurrens/GrpcJsonParseIssue/blob/master/ParseError1.PNG?raw=true)
