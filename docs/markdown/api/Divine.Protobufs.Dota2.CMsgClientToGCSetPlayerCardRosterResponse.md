# <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterResponse"></a> Class CMsgClientToGCSetPlayerCardRosterResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCSetPlayerCardRosterResponse : IMessage<CMsgClientToGCSetPlayerCardRosterResponse>, IEquatable<CMsgClientToGCSetPlayerCardRosterResponse>, IDeepCloneable<CMsgClientToGCSetPlayerCardRosterResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCSetPlayerCardRosterResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetPlayerCardRosterResponse.md)

#### Implements

IMessage<CMsgClientToGCSetPlayerCardRosterResponse\>, 
[IEquatable<CMsgClientToGCSetPlayerCardRosterResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCSetPlayerCardRosterResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCSetPlayerCardRosterResponse\>\(CMsgClientToGCSetPlayerCardRosterResponse, params CMsgClientToGCSetPlayerCardRosterResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterResponse__ctor"></a> CMsgClientToGCSetPlayerCardRosterResponse\(\)

```csharp
public CMsgClientToGCSetPlayerCardRosterResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterResponse_"></a> CMsgClientToGCSetPlayerCardRosterResponse\(CMsgClientToGCSetPlayerCardRosterResponse\)

```csharp
public CMsgClientToGCSetPlayerCardRosterResponse(CMsgClientToGCSetPlayerCardRosterResponse other)
```

#### Parameters

`other` [CMsgClientToGCSetPlayerCardRosterResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetPlayerCardRosterResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCSetPlayerCardRosterResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCSetPlayerCardRosterResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetPlayerCardRosterResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterResponse_Result"></a> Result

```csharp
public CMsgClientToGCSetPlayerCardRosterResponse.Types.Result Result { get; set; }
```

#### Property Value

 [CMsgClientToGCSetPlayerCardRosterResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetPlayerCardRosterResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCSetPlayerCardRosterResponse.Types.md).[Result](Divine.Protobufs.Dota2.CMsgClientToGCSetPlayerCardRosterResponse.Types.Result.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCSetPlayerCardRosterResponse Clone()
```

#### Returns

 [CMsgClientToGCSetPlayerCardRosterResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetPlayerCardRosterResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterResponse_"></a> Equals\(CMsgClientToGCSetPlayerCardRosterResponse\)

```csharp
public bool Equals(CMsgClientToGCSetPlayerCardRosterResponse other)
```

#### Parameters

`other` [CMsgClientToGCSetPlayerCardRosterResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetPlayerCardRosterResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterResponse_"></a> MergeFrom\(CMsgClientToGCSetPlayerCardRosterResponse\)

```csharp
public void MergeFrom(CMsgClientToGCSetPlayerCardRosterResponse other)
```

#### Parameters

`other` [CMsgClientToGCSetPlayerCardRosterResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetPlayerCardRosterResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetPlayerCardRosterResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

