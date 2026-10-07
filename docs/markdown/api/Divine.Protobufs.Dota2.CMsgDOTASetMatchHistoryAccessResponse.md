# <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccessResponse"></a> Class CMsgDOTASetMatchHistoryAccessResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTASetMatchHistoryAccessResponse : IMessage<CMsgDOTASetMatchHistoryAccessResponse>, IEquatable<CMsgDOTASetMatchHistoryAccessResponse>, IDeepCloneable<CMsgDOTASetMatchHistoryAccessResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTASetMatchHistoryAccessResponse](Divine.Protobufs.Dota2.CMsgDOTASetMatchHistoryAccessResponse.md)

#### Implements

IMessage<CMsgDOTASetMatchHistoryAccessResponse\>, 
[IEquatable<CMsgDOTASetMatchHistoryAccessResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTASetMatchHistoryAccessResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTASetMatchHistoryAccessResponse\>\(CMsgDOTASetMatchHistoryAccessResponse, params CMsgDOTASetMatchHistoryAccessResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccessResponse__ctor"></a> CMsgDOTASetMatchHistoryAccessResponse\(\)

```csharp
public CMsgDOTASetMatchHistoryAccessResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccessResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccessResponse_"></a> CMsgDOTASetMatchHistoryAccessResponse\(CMsgDOTASetMatchHistoryAccessResponse\)

```csharp
public CMsgDOTASetMatchHistoryAccessResponse(CMsgDOTASetMatchHistoryAccessResponse other)
```

#### Parameters

`other` [CMsgDOTASetMatchHistoryAccessResponse](Divine.Protobufs.Dota2.CMsgDOTASetMatchHistoryAccessResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccessResponse_EresultFieldNumber"></a> EresultFieldNumber

```csharp
public const int EresultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccessResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccessResponse_Eresult"></a> Eresult

```csharp
public uint Eresult { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccessResponse_HasEresult"></a> HasEresult

```csharp
public bool HasEresult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccessResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTASetMatchHistoryAccessResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTASetMatchHistoryAccessResponse](Divine.Protobufs.Dota2.CMsgDOTASetMatchHistoryAccessResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccessResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccessResponse_ClearEresult"></a> ClearEresult\(\)

```csharp
public void ClearEresult()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccessResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTASetMatchHistoryAccessResponse Clone()
```

#### Returns

 [CMsgDOTASetMatchHistoryAccessResponse](Divine.Protobufs.Dota2.CMsgDOTASetMatchHistoryAccessResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccessResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccessResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccessResponse_"></a> Equals\(CMsgDOTASetMatchHistoryAccessResponse\)

```csharp
public bool Equals(CMsgDOTASetMatchHistoryAccessResponse other)
```

#### Parameters

`other` [CMsgDOTASetMatchHistoryAccessResponse](Divine.Protobufs.Dota2.CMsgDOTASetMatchHistoryAccessResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccessResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccessResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccessResponse_"></a> MergeFrom\(CMsgDOTASetMatchHistoryAccessResponse\)

```csharp
public void MergeFrom(CMsgDOTASetMatchHistoryAccessResponse other)
```

#### Parameters

`other` [CMsgDOTASetMatchHistoryAccessResponse](Divine.Protobufs.Dota2.CMsgDOTASetMatchHistoryAccessResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccessResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccessResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetMatchHistoryAccessResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

