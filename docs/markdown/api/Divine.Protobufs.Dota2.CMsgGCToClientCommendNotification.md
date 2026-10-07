# <a id="Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification"></a> Class CMsgGCToClientCommendNotification

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientCommendNotification : IMessage<CMsgGCToClientCommendNotification>, IEquatable<CMsgGCToClientCommendNotification>, IDeepCloneable<CMsgGCToClientCommendNotification>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientCommendNotification](Divine.Protobufs.Dota2.CMsgGCToClientCommendNotification.md)

#### Implements

IMessage<CMsgGCToClientCommendNotification\>, 
[IEquatable<CMsgGCToClientCommendNotification\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientCommendNotification\>, 
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
[EnumerableExtensions.In<CMsgGCToClientCommendNotification\>\(CMsgGCToClientCommendNotification, params CMsgGCToClientCommendNotification\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification__ctor"></a> CMsgGCToClientCommendNotification\(\)

```csharp
public CMsgGCToClientCommendNotification()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification__ctor_Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification_"></a> CMsgGCToClientCommendNotification\(CMsgGCToClientCommendNotification\)

```csharp
public CMsgGCToClientCommendNotification(CMsgGCToClientCommendNotification other)
```

#### Parameters

`other` [CMsgGCToClientCommendNotification](Divine.Protobufs.Dota2.CMsgGCToClientCommendNotification.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification_CommenderAccountIdFieldNumber"></a> CommenderAccountIdFieldNumber

```csharp
public const int CommenderAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification_CommenderHeroIdFieldNumber"></a> CommenderHeroIdFieldNumber

```csharp
public const int CommenderHeroIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification_CommenderNameFieldNumber"></a> CommenderNameFieldNumber

```csharp
public const int CommenderNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification_FlagsFieldNumber"></a> FlagsFieldNumber

```csharp
public const int FlagsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification_CommenderAccountId"></a> CommenderAccountId

```csharp
public uint CommenderAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification_CommenderHeroId"></a> CommenderHeroId

```csharp
public int CommenderHeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification_CommenderName"></a> CommenderName

```csharp
public string CommenderName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification_Flags"></a> Flags

```csharp
public uint Flags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification_HasCommenderAccountId"></a> HasCommenderAccountId

```csharp
public bool HasCommenderAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification_HasCommenderHeroId"></a> HasCommenderHeroId

```csharp
public bool HasCommenderHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification_HasCommenderName"></a> HasCommenderName

```csharp
public bool HasCommenderName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification_HasFlags"></a> HasFlags

```csharp
public bool HasFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientCommendNotification> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientCommendNotification](Divine.Protobufs.Dota2.CMsgGCToClientCommendNotification.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification_ClearCommenderAccountId"></a> ClearCommenderAccountId\(\)

```csharp
public void ClearCommenderAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification_ClearCommenderHeroId"></a> ClearCommenderHeroId\(\)

```csharp
public void ClearCommenderHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification_ClearCommenderName"></a> ClearCommenderName\(\)

```csharp
public void ClearCommenderName()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification_ClearFlags"></a> ClearFlags\(\)

```csharp
public void ClearFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientCommendNotification Clone()
```

#### Returns

 [CMsgGCToClientCommendNotification](Divine.Protobufs.Dota2.CMsgGCToClientCommendNotification.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification_Equals_Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification_"></a> Equals\(CMsgGCToClientCommendNotification\)

```csharp
public bool Equals(CMsgGCToClientCommendNotification other)
```

#### Parameters

`other` [CMsgGCToClientCommendNotification](Divine.Protobufs.Dota2.CMsgGCToClientCommendNotification.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification_"></a> MergeFrom\(CMsgGCToClientCommendNotification\)

```csharp
public void MergeFrom(CMsgGCToClientCommendNotification other)
```

#### Parameters

`other` [CMsgGCToClientCommendNotification](Divine.Protobufs.Dota2.CMsgGCToClientCommendNotification.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCommendNotification_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

