# <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePredictionResponse"></a> Class CMsgClientToGCSelectCompendiumInGamePredictionResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCSelectCompendiumInGamePredictionResponse : IMessage<CMsgClientToGCSelectCompendiumInGamePredictionResponse>, IEquatable<CMsgClientToGCSelectCompendiumInGamePredictionResponse>, IDeepCloneable<CMsgClientToGCSelectCompendiumInGamePredictionResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCSelectCompendiumInGamePredictionResponse](Divine.Protobufs.Dota2.CMsgClientToGCSelectCompendiumInGamePredictionResponse.md)

#### Implements

IMessage<CMsgClientToGCSelectCompendiumInGamePredictionResponse\>, 
[IEquatable<CMsgClientToGCSelectCompendiumInGamePredictionResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCSelectCompendiumInGamePredictionResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCSelectCompendiumInGamePredictionResponse\>\(CMsgClientToGCSelectCompendiumInGamePredictionResponse, params CMsgClientToGCSelectCompendiumInGamePredictionResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePredictionResponse__ctor"></a> CMsgClientToGCSelectCompendiumInGamePredictionResponse\(\)

```csharp
public CMsgClientToGCSelectCompendiumInGamePredictionResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePredictionResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePredictionResponse_"></a> CMsgClientToGCSelectCompendiumInGamePredictionResponse\(CMsgClientToGCSelectCompendiumInGamePredictionResponse\)

```csharp
public CMsgClientToGCSelectCompendiumInGamePredictionResponse(CMsgClientToGCSelectCompendiumInGamePredictionResponse other)
```

#### Parameters

`other` [CMsgClientToGCSelectCompendiumInGamePredictionResponse](Divine.Protobufs.Dota2.CMsgClientToGCSelectCompendiumInGamePredictionResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePredictionResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePredictionResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePredictionResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePredictionResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCSelectCompendiumInGamePredictionResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCSelectCompendiumInGamePredictionResponse](Divine.Protobufs.Dota2.CMsgClientToGCSelectCompendiumInGamePredictionResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePredictionResponse_Result"></a> Result

```csharp
public CMsgClientToGCSelectCompendiumInGamePredictionResponse.Types.EResult Result { get; set; }
```

#### Property Value

 [CMsgClientToGCSelectCompendiumInGamePredictionResponse](Divine.Protobufs.Dota2.CMsgClientToGCSelectCompendiumInGamePredictionResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCSelectCompendiumInGamePredictionResponse.Types.md).[EResult](Divine.Protobufs.Dota2.CMsgClientToGCSelectCompendiumInGamePredictionResponse.Types.EResult.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePredictionResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePredictionResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePredictionResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCSelectCompendiumInGamePredictionResponse Clone()
```

#### Returns

 [CMsgClientToGCSelectCompendiumInGamePredictionResponse](Divine.Protobufs.Dota2.CMsgClientToGCSelectCompendiumInGamePredictionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePredictionResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePredictionResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePredictionResponse_"></a> Equals\(CMsgClientToGCSelectCompendiumInGamePredictionResponse\)

```csharp
public bool Equals(CMsgClientToGCSelectCompendiumInGamePredictionResponse other)
```

#### Parameters

`other` [CMsgClientToGCSelectCompendiumInGamePredictionResponse](Divine.Protobufs.Dota2.CMsgClientToGCSelectCompendiumInGamePredictionResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePredictionResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePredictionResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePredictionResponse_"></a> MergeFrom\(CMsgClientToGCSelectCompendiumInGamePredictionResponse\)

```csharp
public void MergeFrom(CMsgClientToGCSelectCompendiumInGamePredictionResponse other)
```

#### Parameters

`other` [CMsgClientToGCSelectCompendiumInGamePredictionResponse](Divine.Protobufs.Dota2.CMsgClientToGCSelectCompendiumInGamePredictionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePredictionResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePredictionResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSelectCompendiumInGamePredictionResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

