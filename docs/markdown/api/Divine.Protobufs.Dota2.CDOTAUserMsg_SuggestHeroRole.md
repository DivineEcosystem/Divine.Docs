# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroRole"></a> Class CDOTAUserMsg\_SuggestHeroRole

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_SuggestHeroRole : IMessage<CDOTAUserMsg_SuggestHeroRole>, IEquatable<CDOTAUserMsg_SuggestHeroRole>, IDeepCloneable<CDOTAUserMsg_SuggestHeroRole>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_SuggestHeroRole](Divine.Protobufs.Dota2.CDOTAUserMsg\_SuggestHeroRole.md)

#### Implements

IMessage<CDOTAUserMsg\_SuggestHeroRole\>, 
[IEquatable<CDOTAUserMsg\_SuggestHeroRole\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_SuggestHeroRole\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_SuggestHeroRole\>\(CDOTAUserMsg\_SuggestHeroRole, params CDOTAUserMsg\_SuggestHeroRole\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroRole__ctor"></a> CDOTAUserMsg\_SuggestHeroRole\(\)

```csharp
public CDOTAUserMsg_SuggestHeroRole()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroRole__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroRole_"></a> CDOTAUserMsg\_SuggestHeroRole\(CDOTAUserMsg\_SuggestHeroRole\)

```csharp
public CDOTAUserMsg_SuggestHeroRole(CDOTAUserMsg_SuggestHeroRole other)
```

#### Parameters

`other` [CDOTAUserMsg\_SuggestHeroRole](Divine.Protobufs.Dota2.CDOTAUserMsg\_SuggestHeroRole.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroRole_HeroRoleFieldNumber"></a> HeroRoleFieldNumber

```csharp
public const int HeroRoleFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroRole_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroRole_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroRole_HasHeroRole"></a> HasHeroRole

```csharp
public bool HasHeroRole { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroRole_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroRole_HeroRole"></a> HeroRole

```csharp
public string HeroRole { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroRole_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_SuggestHeroRole> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_SuggestHeroRole](Divine.Protobufs.Dota2.CDOTAUserMsg\_SuggestHeroRole.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroRole_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroRole_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroRole_ClearHeroRole"></a> ClearHeroRole\(\)

```csharp
public void ClearHeroRole()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroRole_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroRole_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_SuggestHeroRole Clone()
```

#### Returns

 [CDOTAUserMsg\_SuggestHeroRole](Divine.Protobufs.Dota2.CDOTAUserMsg\_SuggestHeroRole.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroRole_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroRole_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroRole_"></a> Equals\(CDOTAUserMsg\_SuggestHeroRole\)

```csharp
public bool Equals(CDOTAUserMsg_SuggestHeroRole other)
```

#### Parameters

`other` [CDOTAUserMsg\_SuggestHeroRole](Divine.Protobufs.Dota2.CDOTAUserMsg\_SuggestHeroRole.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroRole_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroRole_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroRole_"></a> MergeFrom\(CDOTAUserMsg\_SuggestHeroRole\)

```csharp
public void MergeFrom(CDOTAUserMsg_SuggestHeroRole other)
```

#### Parameters

`other` [CDOTAUserMsg\_SuggestHeroRole](Divine.Protobufs.Dota2.CDOTAUserMsg\_SuggestHeroRole.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroRole_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroRole_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_SuggestHeroRole_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

