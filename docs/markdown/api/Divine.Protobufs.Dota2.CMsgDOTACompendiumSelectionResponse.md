# <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelectionResponse"></a> Class CMsgDOTACompendiumSelectionResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTACompendiumSelectionResponse : IMessage<CMsgDOTACompendiumSelectionResponse>, IEquatable<CMsgDOTACompendiumSelectionResponse>, IDeepCloneable<CMsgDOTACompendiumSelectionResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTACompendiumSelectionResponse](Divine.Protobufs.Dota2.CMsgDOTACompendiumSelectionResponse.md)

#### Implements

IMessage<CMsgDOTACompendiumSelectionResponse\>, 
[IEquatable<CMsgDOTACompendiumSelectionResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTACompendiumSelectionResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTACompendiumSelectionResponse\>\(CMsgDOTACompendiumSelectionResponse, params CMsgDOTACompendiumSelectionResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelectionResponse__ctor"></a> CMsgDOTACompendiumSelectionResponse\(\)

```csharp
public CMsgDOTACompendiumSelectionResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelectionResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTACompendiumSelectionResponse_"></a> CMsgDOTACompendiumSelectionResponse\(CMsgDOTACompendiumSelectionResponse\)

```csharp
public CMsgDOTACompendiumSelectionResponse(CMsgDOTACompendiumSelectionResponse other)
```

#### Parameters

`other` [CMsgDOTACompendiumSelectionResponse](Divine.Protobufs.Dota2.CMsgDOTACompendiumSelectionResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelectionResponse_EresultFieldNumber"></a> EresultFieldNumber

```csharp
public const int EresultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelectionResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelectionResponse_Eresult"></a> Eresult

```csharp
public uint Eresult { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelectionResponse_HasEresult"></a> HasEresult

```csharp
public bool HasEresult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelectionResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTACompendiumSelectionResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTACompendiumSelectionResponse](Divine.Protobufs.Dota2.CMsgDOTACompendiumSelectionResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelectionResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelectionResponse_ClearEresult"></a> ClearEresult\(\)

```csharp
public void ClearEresult()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelectionResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTACompendiumSelectionResponse Clone()
```

#### Returns

 [CMsgDOTACompendiumSelectionResponse](Divine.Protobufs.Dota2.CMsgDOTACompendiumSelectionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelectionResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelectionResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTACompendiumSelectionResponse_"></a> Equals\(CMsgDOTACompendiumSelectionResponse\)

```csharp
public bool Equals(CMsgDOTACompendiumSelectionResponse other)
```

#### Parameters

`other` [CMsgDOTACompendiumSelectionResponse](Divine.Protobufs.Dota2.CMsgDOTACompendiumSelectionResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelectionResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelectionResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTACompendiumSelectionResponse_"></a> MergeFrom\(CMsgDOTACompendiumSelectionResponse\)

```csharp
public void MergeFrom(CMsgDOTACompendiumSelectionResponse other)
```

#### Parameters

`other` [CMsgDOTACompendiumSelectionResponse](Divine.Protobufs.Dota2.CMsgDOTACompendiumSelectionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelectionResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelectionResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumSelectionResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

