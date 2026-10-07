# <a id="Divine_Protobufs_Dota2_CMsgGCToClientMonsterHunterUserDataUpdated"></a> Class CMsgGCToClientMonsterHunterUserDataUpdated

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientMonsterHunterUserDataUpdated : IMessage<CMsgGCToClientMonsterHunterUserDataUpdated>, IEquatable<CMsgGCToClientMonsterHunterUserDataUpdated>, IDeepCloneable<CMsgGCToClientMonsterHunterUserDataUpdated>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientMonsterHunterUserDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientMonsterHunterUserDataUpdated.md)

#### Implements

IMessage<CMsgGCToClientMonsterHunterUserDataUpdated\>, 
[IEquatable<CMsgGCToClientMonsterHunterUserDataUpdated\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientMonsterHunterUserDataUpdated\>, 
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
[EnumerableExtensions.In<CMsgGCToClientMonsterHunterUserDataUpdated\>\(CMsgGCToClientMonsterHunterUserDataUpdated, params CMsgGCToClientMonsterHunterUserDataUpdated\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMonsterHunterUserDataUpdated__ctor"></a> CMsgGCToClientMonsterHunterUserDataUpdated\(\)

```csharp
public CMsgGCToClientMonsterHunterUserDataUpdated()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMonsterHunterUserDataUpdated__ctor_Divine_Protobufs_Dota2_CMsgGCToClientMonsterHunterUserDataUpdated_"></a> CMsgGCToClientMonsterHunterUserDataUpdated\(CMsgGCToClientMonsterHunterUserDataUpdated\)

```csharp
public CMsgGCToClientMonsterHunterUserDataUpdated(CMsgGCToClientMonsterHunterUserDataUpdated other)
```

#### Parameters

`other` [CMsgGCToClientMonsterHunterUserDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientMonsterHunterUserDataUpdated.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMonsterHunterUserDataUpdated_UserDataFieldNumber"></a> UserDataFieldNumber

```csharp
public const int UserDataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMonsterHunterUserDataUpdated_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMonsterHunterUserDataUpdated_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientMonsterHunterUserDataUpdated> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientMonsterHunterUserDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientMonsterHunterUserDataUpdated.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMonsterHunterUserDataUpdated_UserData"></a> UserData

```csharp
public CMsgMonsterHunterUserData UserData { get; set; }
```

#### Property Value

 [CMsgMonsterHunterUserData](Divine.Protobufs.Dota2.CMsgMonsterHunterUserData.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMonsterHunterUserDataUpdated_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMonsterHunterUserDataUpdated_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientMonsterHunterUserDataUpdated Clone()
```

#### Returns

 [CMsgGCToClientMonsterHunterUserDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientMonsterHunterUserDataUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMonsterHunterUserDataUpdated_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMonsterHunterUserDataUpdated_Equals_Divine_Protobufs_Dota2_CMsgGCToClientMonsterHunterUserDataUpdated_"></a> Equals\(CMsgGCToClientMonsterHunterUserDataUpdated\)

```csharp
public bool Equals(CMsgGCToClientMonsterHunterUserDataUpdated other)
```

#### Parameters

`other` [CMsgGCToClientMonsterHunterUserDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientMonsterHunterUserDataUpdated.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMonsterHunterUserDataUpdated_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMonsterHunterUserDataUpdated_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientMonsterHunterUserDataUpdated_"></a> MergeFrom\(CMsgGCToClientMonsterHunterUserDataUpdated\)

```csharp
public void MergeFrom(CMsgGCToClientMonsterHunterUserDataUpdated other)
```

#### Parameters

`other` [CMsgGCToClientMonsterHunterUserDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientMonsterHunterUserDataUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMonsterHunterUserDataUpdated_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMonsterHunterUserDataUpdated_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientMonsterHunterUserDataUpdated_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

