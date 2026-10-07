# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishments"></a> Class CMsgClientToGCRequestPlayerHeroRecentAccomplishments

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestPlayerHeroRecentAccomplishments : IMessage<CMsgClientToGCRequestPlayerHeroRecentAccomplishments>, IEquatable<CMsgClientToGCRequestPlayerHeroRecentAccomplishments>, IDeepCloneable<CMsgClientToGCRequestPlayerHeroRecentAccomplishments>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestPlayerHeroRecentAccomplishments](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerHeroRecentAccomplishments.md)

#### Implements

IMessage<CMsgClientToGCRequestPlayerHeroRecentAccomplishments\>, 
[IEquatable<CMsgClientToGCRequestPlayerHeroRecentAccomplishments\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestPlayerHeroRecentAccomplishments\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestPlayerHeroRecentAccomplishments\>\(CMsgClientToGCRequestPlayerHeroRecentAccomplishments, params CMsgClientToGCRequestPlayerHeroRecentAccomplishments\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishments__ctor"></a> CMsgClientToGCRequestPlayerHeroRecentAccomplishments\(\)

```csharp
public CMsgClientToGCRequestPlayerHeroRecentAccomplishments()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishments__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishments_"></a> CMsgClientToGCRequestPlayerHeroRecentAccomplishments\(CMsgClientToGCRequestPlayerHeroRecentAccomplishments\)

```csharp
public CMsgClientToGCRequestPlayerHeroRecentAccomplishments(CMsgClientToGCRequestPlayerHeroRecentAccomplishments other)
```

#### Parameters

`other` [CMsgClientToGCRequestPlayerHeroRecentAccomplishments](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerHeroRecentAccomplishments.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishments_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishments_HeroIdFieldNumber"></a> HeroIdFieldNumber

```csharp
public const int HeroIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishments_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishments_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishments_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishments_HasHeroId"></a> HasHeroId

```csharp
public bool HasHeroId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishments_HeroId"></a> HeroId

```csharp
public int HeroId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishments_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestPlayerHeroRecentAccomplishments> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestPlayerHeroRecentAccomplishments](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerHeroRecentAccomplishments.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishments_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishments_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishments_ClearHeroId"></a> ClearHeroId\(\)

```csharp
public void ClearHeroId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishments_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestPlayerHeroRecentAccomplishments Clone()
```

#### Returns

 [CMsgClientToGCRequestPlayerHeroRecentAccomplishments](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerHeroRecentAccomplishments.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishments_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishments_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishments_"></a> Equals\(CMsgClientToGCRequestPlayerHeroRecentAccomplishments\)

```csharp
public bool Equals(CMsgClientToGCRequestPlayerHeroRecentAccomplishments other)
```

#### Parameters

`other` [CMsgClientToGCRequestPlayerHeroRecentAccomplishments](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerHeroRecentAccomplishments.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishments_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishments_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishments_"></a> MergeFrom\(CMsgClientToGCRequestPlayerHeroRecentAccomplishments\)

```csharp
public void MergeFrom(CMsgClientToGCRequestPlayerHeroRecentAccomplishments other)
```

#### Parameters

`other` [CMsgClientToGCRequestPlayerHeroRecentAccomplishments](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerHeroRecentAccomplishments.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishments_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishments_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishments_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

