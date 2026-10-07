# <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse"></a> Class CMsgDOTACompendiumDataResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTACompendiumDataResponse : IMessage<CMsgDOTACompendiumDataResponse>, IEquatable<CMsgDOTACompendiumDataResponse>, IDeepCloneable<CMsgDOTACompendiumDataResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTACompendiumDataResponse](Divine.Protobufs.Dota2.CMsgDOTACompendiumDataResponse.md)

#### Implements

IMessage<CMsgDOTACompendiumDataResponse\>, 
[IEquatable<CMsgDOTACompendiumDataResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTACompendiumDataResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTACompendiumDataResponse\>\(CMsgDOTACompendiumDataResponse, params CMsgDOTACompendiumDataResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse__ctor"></a> CMsgDOTACompendiumDataResponse\(\)

```csharp
public CMsgDOTACompendiumDataResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse_"></a> CMsgDOTACompendiumDataResponse\(CMsgDOTACompendiumDataResponse\)

```csharp
public CMsgDOTACompendiumDataResponse(CMsgDOTACompendiumDataResponse other)
```

#### Parameters

`other` [CMsgDOTACompendiumDataResponse](Divine.Protobufs.Dota2.CMsgDOTACompendiumDataResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse_CompendiumDataFieldNumber"></a> CompendiumDataFieldNumber

```csharp
public const int CompendiumDataFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse_LeagueidFieldNumber"></a> LeagueidFieldNumber

```csharp
public const int LeagueidFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse_CompendiumData"></a> CompendiumData

```csharp
public CMsgDOTACompendiumData CompendiumData { get; set; }
```

#### Property Value

 [CMsgDOTACompendiumData](Divine.Protobufs.Dota2.CMsgDOTACompendiumData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse_HasLeagueid"></a> HasLeagueid

```csharp
public bool HasLeagueid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse_Leagueid"></a> Leagueid

```csharp
public uint Leagueid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTACompendiumDataResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTACompendiumDataResponse](Divine.Protobufs.Dota2.CMsgDOTACompendiumDataResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse_Result"></a> Result

```csharp
public uint Result { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse_ClearLeagueid"></a> ClearLeagueid\(\)

```csharp
public void ClearLeagueid()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTACompendiumDataResponse Clone()
```

#### Returns

 [CMsgDOTACompendiumDataResponse](Divine.Protobufs.Dota2.CMsgDOTACompendiumDataResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse_"></a> Equals\(CMsgDOTACompendiumDataResponse\)

```csharp
public bool Equals(CMsgDOTACompendiumDataResponse other)
```

#### Parameters

`other` [CMsgDOTACompendiumDataResponse](Divine.Protobufs.Dota2.CMsgDOTACompendiumDataResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse_"></a> MergeFrom\(CMsgDOTACompendiumDataResponse\)

```csharp
public void MergeFrom(CMsgDOTACompendiumDataResponse other)
```

#### Parameters

`other` [CMsgDOTACompendiumDataResponse](Divine.Protobufs.Dota2.CMsgDOTACompendiumDataResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumDataResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

