# <a id="Divine_Protobufs_Dota2_CMsgGCServerVersionUpdated"></a> Class CMsgGCServerVersionUpdated

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCServerVersionUpdated : IMessage<CMsgGCServerVersionUpdated>, IEquatable<CMsgGCServerVersionUpdated>, IDeepCloneable<CMsgGCServerVersionUpdated>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCServerVersionUpdated](Divine.Protobufs.Dota2.CMsgGCServerVersionUpdated.md)

#### Implements

IMessage<CMsgGCServerVersionUpdated\>, 
[IEquatable<CMsgGCServerVersionUpdated\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCServerVersionUpdated\>, 
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
[EnumerableExtensions.In<CMsgGCServerVersionUpdated\>\(CMsgGCServerVersionUpdated, params CMsgGCServerVersionUpdated\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCServerVersionUpdated__ctor"></a> CMsgGCServerVersionUpdated\(\)

```csharp
public CMsgGCServerVersionUpdated()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCServerVersionUpdated__ctor_Divine_Protobufs_Dota2_CMsgGCServerVersionUpdated_"></a> CMsgGCServerVersionUpdated\(CMsgGCServerVersionUpdated\)

```csharp
public CMsgGCServerVersionUpdated(CMsgGCServerVersionUpdated other)
```

#### Parameters

`other` [CMsgGCServerVersionUpdated](Divine.Protobufs.Dota2.CMsgGCServerVersionUpdated.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCServerVersionUpdated_ServerVersionFieldNumber"></a> ServerVersionFieldNumber

```csharp
public const int ServerVersionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCServerVersionUpdated_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCServerVersionUpdated_HasServerVersion"></a> HasServerVersion

```csharp
public bool HasServerVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCServerVersionUpdated_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCServerVersionUpdated> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCServerVersionUpdated](Divine.Protobufs.Dota2.CMsgGCServerVersionUpdated.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCServerVersionUpdated_ServerVersion"></a> ServerVersion

```csharp
public uint ServerVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCServerVersionUpdated_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCServerVersionUpdated_ClearServerVersion"></a> ClearServerVersion\(\)

```csharp
public void ClearServerVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCServerVersionUpdated_Clone"></a> Clone\(\)

```csharp
public CMsgGCServerVersionUpdated Clone()
```

#### Returns

 [CMsgGCServerVersionUpdated](Divine.Protobufs.Dota2.CMsgGCServerVersionUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCServerVersionUpdated_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCServerVersionUpdated_Equals_Divine_Protobufs_Dota2_CMsgGCServerVersionUpdated_"></a> Equals\(CMsgGCServerVersionUpdated\)

```csharp
public bool Equals(CMsgGCServerVersionUpdated other)
```

#### Parameters

`other` [CMsgGCServerVersionUpdated](Divine.Protobufs.Dota2.CMsgGCServerVersionUpdated.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCServerVersionUpdated_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCServerVersionUpdated_MergeFrom_Divine_Protobufs_Dota2_CMsgGCServerVersionUpdated_"></a> MergeFrom\(CMsgGCServerVersionUpdated\)

```csharp
public void MergeFrom(CMsgGCServerVersionUpdated other)
```

#### Parameters

`other` [CMsgGCServerVersionUpdated](Divine.Protobufs.Dota2.CMsgGCServerVersionUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCServerVersionUpdated_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCServerVersionUpdated_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCServerVersionUpdated_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

