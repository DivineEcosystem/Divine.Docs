# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAll"></a> Class CMsgClientToGCOverworldDevResetAll

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldDevResetAll : IMessage<CMsgClientToGCOverworldDevResetAll>, IEquatable<CMsgClientToGCOverworldDevResetAll>, IDeepCloneable<CMsgClientToGCOverworldDevResetAll>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldDevResetAll](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevResetAll.md)

#### Implements

IMessage<CMsgClientToGCOverworldDevResetAll\>, 
[IEquatable<CMsgClientToGCOverworldDevResetAll\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldDevResetAll\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldDevResetAll\>\(CMsgClientToGCOverworldDevResetAll, params CMsgClientToGCOverworldDevResetAll\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAll__ctor"></a> CMsgClientToGCOverworldDevResetAll\(\)

```csharp
public CMsgClientToGCOverworldDevResetAll()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAll__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAll_"></a> CMsgClientToGCOverworldDevResetAll\(CMsgClientToGCOverworldDevResetAll\)

```csharp
public CMsgClientToGCOverworldDevResetAll(CMsgClientToGCOverworldDevResetAll other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevResetAll](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevResetAll.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAll_OverworldIdFieldNumber"></a> OverworldIdFieldNumber

```csharp
public const int OverworldIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAll_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAll_HasOverworldId"></a> HasOverworldId

```csharp
public bool HasOverworldId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAll_OverworldId"></a> OverworldId

```csharp
public uint OverworldId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAll_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldDevResetAll> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldDevResetAll](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevResetAll.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAll_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAll_ClearOverworldId"></a> ClearOverworldId\(\)

```csharp
public void ClearOverworldId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAll_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldDevResetAll Clone()
```

#### Returns

 [CMsgClientToGCOverworldDevResetAll](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevResetAll.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAll_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAll_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAll_"></a> Equals\(CMsgClientToGCOverworldDevResetAll\)

```csharp
public bool Equals(CMsgClientToGCOverworldDevResetAll other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevResetAll](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevResetAll.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAll_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAll_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAll_"></a> MergeFrom\(CMsgClientToGCOverworldDevResetAll\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldDevResetAll other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevResetAll](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevResetAll.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAll_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAll_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevResetAll_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

