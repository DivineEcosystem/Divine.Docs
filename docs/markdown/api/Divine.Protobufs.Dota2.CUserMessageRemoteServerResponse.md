# <a id="Divine_Protobufs_Dota2_CUserMessageRemoteServerResponse"></a> Class CUserMessageRemoteServerResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageRemoteServerResponse : IMessage<CUserMessageRemoteServerResponse>, IEquatable<CUserMessageRemoteServerResponse>, IDeepCloneable<CUserMessageRemoteServerResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageRemoteServerResponse](Divine.Protobufs.Dota2.CUserMessageRemoteServerResponse.md)

#### Implements

IMessage<CUserMessageRemoteServerResponse\>, 
[IEquatable<CUserMessageRemoteServerResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageRemoteServerResponse\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<CUserMessageRemoteServerResponse\>\(CUserMessageRemoteServerResponse, params CUserMessageRemoteServerResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageRemoteServerResponse__ctor"></a> CUserMessageRemoteServerResponse\(\)

```csharp
public CUserMessageRemoteServerResponse()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageRemoteServerResponse__ctor_Divine_Protobufs_Dota2_CUserMessageRemoteServerResponse_"></a> CUserMessageRemoteServerResponse\(CUserMessageRemoteServerResponse\)

```csharp
public CUserMessageRemoteServerResponse(CUserMessageRemoteServerResponse other)
```

#### Parameters

`other` [CUserMessageRemoteServerResponse](Divine.Protobufs.Dota2.CUserMessageRemoteServerResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageRemoteServerResponse_CommandResultFieldNumber"></a> CommandResultFieldNumber

```csharp
public const int CommandResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageRemoteServerResponse_RequestFieldNumber"></a> RequestFieldNumber

```csharp
public const int RequestFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageRemoteServerResponse_ResultsFieldNumber"></a> ResultsFieldNumber

```csharp
public const int ResultsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageRemoteServerResponse_CommandResult"></a> CommandResult

```csharp
public CUserMessageRemoteServerResponse.Types.ECommandResult CommandResult { get; set; }
```

#### Property Value

 [CUserMessageRemoteServerResponse](Divine.Protobufs.Dota2.CUserMessageRemoteServerResponse.md).[Types](Divine.Protobufs.Dota2.CUserMessageRemoteServerResponse.Types.md).[ECommandResult](Divine.Protobufs.Dota2.CUserMessageRemoteServerResponse.Types.ECommandResult.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageRemoteServerResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageRemoteServerResponse_HasCommandResult"></a> HasCommandResult

```csharp
public bool HasCommandResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageRemoteServerResponse_HasRequest"></a> HasRequest

```csharp
public bool HasRequest { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageRemoteServerResponse_HasResults"></a> HasResults

```csharp
public bool HasResults { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageRemoteServerResponse_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageRemoteServerResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageRemoteServerResponse](Divine.Protobufs.Dota2.CUserMessageRemoteServerResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessageRemoteServerResponse_Request"></a> Request

```csharp
public string Request { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageRemoteServerResponse_Results"></a> Results

```csharp
public string Results { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageRemoteServerResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageRemoteServerResponse_ClearCommandResult"></a> ClearCommandResult\(\)

```csharp
public void ClearCommandResult()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageRemoteServerResponse_ClearRequest"></a> ClearRequest\(\)

```csharp
public void ClearRequest()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageRemoteServerResponse_ClearResults"></a> ClearResults\(\)

```csharp
public void ClearResults()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageRemoteServerResponse_Clone"></a> Clone\(\)

```csharp
public CUserMessageRemoteServerResponse Clone()
```

#### Returns

 [CUserMessageRemoteServerResponse](Divine.Protobufs.Dota2.CUserMessageRemoteServerResponse.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageRemoteServerResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageRemoteServerResponse_Equals_Divine_Protobufs_Dota2_CUserMessageRemoteServerResponse_"></a> Equals\(CUserMessageRemoteServerResponse\)

```csharp
public bool Equals(CUserMessageRemoteServerResponse other)
```

#### Parameters

`other` [CUserMessageRemoteServerResponse](Divine.Protobufs.Dota2.CUserMessageRemoteServerResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageRemoteServerResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageRemoteServerResponse_MergeFrom_Divine_Protobufs_Dota2_CUserMessageRemoteServerResponse_"></a> MergeFrom\(CUserMessageRemoteServerResponse\)

```csharp
public void MergeFrom(CUserMessageRemoteServerResponse other)
```

#### Parameters

`other` [CUserMessageRemoteServerResponse](Divine.Protobufs.Dota2.CUserMessageRemoteServerResponse.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageRemoteServerResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageRemoteServerResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageRemoteServerResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

