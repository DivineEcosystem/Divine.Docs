# <a id="Divine_Protobufs_Dota2_CMsgGCClientVersionUpdated"></a> Class CMsgGCClientVersionUpdated

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCClientVersionUpdated : IMessage<CMsgGCClientVersionUpdated>, IEquatable<CMsgGCClientVersionUpdated>, IDeepCloneable<CMsgGCClientVersionUpdated>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCClientVersionUpdated](Divine.Protobufs.Dota2.CMsgGCClientVersionUpdated.md)

#### Implements

IMessage<CMsgGCClientVersionUpdated\>, 
[IEquatable<CMsgGCClientVersionUpdated\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCClientVersionUpdated\>, 
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
[EnumerableExtensions.In<CMsgGCClientVersionUpdated\>\(CMsgGCClientVersionUpdated, params CMsgGCClientVersionUpdated\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCClientVersionUpdated__ctor"></a> CMsgGCClientVersionUpdated\(\)

```csharp
public CMsgGCClientVersionUpdated()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCClientVersionUpdated__ctor_Divine_Protobufs_Dota2_CMsgGCClientVersionUpdated_"></a> CMsgGCClientVersionUpdated\(CMsgGCClientVersionUpdated\)

```csharp
public CMsgGCClientVersionUpdated(CMsgGCClientVersionUpdated other)
```

#### Parameters

`other` [CMsgGCClientVersionUpdated](Divine.Protobufs.Dota2.CMsgGCClientVersionUpdated.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCClientVersionUpdated_ClientVersionFieldNumber"></a> ClientVersionFieldNumber

```csharp
public const int ClientVersionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCClientVersionUpdated_ClientVersion"></a> ClientVersion

```csharp
public uint ClientVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCClientVersionUpdated_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCClientVersionUpdated_HasClientVersion"></a> HasClientVersion

```csharp
public bool HasClientVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCClientVersionUpdated_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCClientVersionUpdated> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCClientVersionUpdated](Divine.Protobufs.Dota2.CMsgGCClientVersionUpdated.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCClientVersionUpdated_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCClientVersionUpdated_ClearClientVersion"></a> ClearClientVersion\(\)

```csharp
public void ClearClientVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCClientVersionUpdated_Clone"></a> Clone\(\)

```csharp
public CMsgGCClientVersionUpdated Clone()
```

#### Returns

 [CMsgGCClientVersionUpdated](Divine.Protobufs.Dota2.CMsgGCClientVersionUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCClientVersionUpdated_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCClientVersionUpdated_Equals_Divine_Protobufs_Dota2_CMsgGCClientVersionUpdated_"></a> Equals\(CMsgGCClientVersionUpdated\)

```csharp
public bool Equals(CMsgGCClientVersionUpdated other)
```

#### Parameters

`other` [CMsgGCClientVersionUpdated](Divine.Protobufs.Dota2.CMsgGCClientVersionUpdated.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCClientVersionUpdated_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCClientVersionUpdated_MergeFrom_Divine_Protobufs_Dota2_CMsgGCClientVersionUpdated_"></a> MergeFrom\(CMsgGCClientVersionUpdated\)

```csharp
public void MergeFrom(CMsgGCClientVersionUpdated other)
```

#### Parameters

`other` [CMsgGCClientVersionUpdated](Divine.Protobufs.Dota2.CMsgGCClientVersionUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCClientVersionUpdated_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCClientVersionUpdated_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCClientVersionUpdated_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

