# <a id="Divine_Protobufs_Dota2_CMsgAccountGuildsPersonaInfo"></a> Class CMsgAccountGuildsPersonaInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgAccountGuildsPersonaInfo : IMessage<CMsgAccountGuildsPersonaInfo>, IEquatable<CMsgAccountGuildsPersonaInfo>, IDeepCloneable<CMsgAccountGuildsPersonaInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgAccountGuildsPersonaInfo](Divine.Protobufs.Dota2.CMsgAccountGuildsPersonaInfo.md)

#### Implements

IMessage<CMsgAccountGuildsPersonaInfo\>, 
[IEquatable<CMsgAccountGuildsPersonaInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgAccountGuildsPersonaInfo\>, 
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
[EnumerableExtensions.In<CMsgAccountGuildsPersonaInfo\>\(CMsgAccountGuildsPersonaInfo, params CMsgAccountGuildsPersonaInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildsPersonaInfo__ctor"></a> CMsgAccountGuildsPersonaInfo\(\)

```csharp
public CMsgAccountGuildsPersonaInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildsPersonaInfo__ctor_Divine_Protobufs_Dota2_CMsgAccountGuildsPersonaInfo_"></a> CMsgAccountGuildsPersonaInfo\(CMsgAccountGuildsPersonaInfo\)

```csharp
public CMsgAccountGuildsPersonaInfo(CMsgAccountGuildsPersonaInfo other)
```

#### Parameters

`other` [CMsgAccountGuildsPersonaInfo](Divine.Protobufs.Dota2.CMsgAccountGuildsPersonaInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildsPersonaInfo_GuildPersonaInfosFieldNumber"></a> GuildPersonaInfosFieldNumber

```csharp
public const int GuildPersonaInfosFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildsPersonaInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildsPersonaInfo_GuildPersonaInfos"></a> GuildPersonaInfos

```csharp
public RepeatedField<CMsgGuildPersonaInfo> GuildPersonaInfos { get; }
```

#### Property Value

 RepeatedField<[CMsgGuildPersonaInfo](Divine.Protobufs.Dota2.CMsgGuildPersonaInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildsPersonaInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgAccountGuildsPersonaInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgAccountGuildsPersonaInfo](Divine.Protobufs.Dota2.CMsgAccountGuildsPersonaInfo.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildsPersonaInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildsPersonaInfo_Clone"></a> Clone\(\)

```csharp
public CMsgAccountGuildsPersonaInfo Clone()
```

#### Returns

 [CMsgAccountGuildsPersonaInfo](Divine.Protobufs.Dota2.CMsgAccountGuildsPersonaInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildsPersonaInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildsPersonaInfo_Equals_Divine_Protobufs_Dota2_CMsgAccountGuildsPersonaInfo_"></a> Equals\(CMsgAccountGuildsPersonaInfo\)

```csharp
public bool Equals(CMsgAccountGuildsPersonaInfo other)
```

#### Parameters

`other` [CMsgAccountGuildsPersonaInfo](Divine.Protobufs.Dota2.CMsgAccountGuildsPersonaInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildsPersonaInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildsPersonaInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgAccountGuildsPersonaInfo_"></a> MergeFrom\(CMsgAccountGuildsPersonaInfo\)

```csharp
public void MergeFrom(CMsgAccountGuildsPersonaInfo other)
```

#### Parameters

`other` [CMsgAccountGuildsPersonaInfo](Divine.Protobufs.Dota2.CMsgAccountGuildsPersonaInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildsPersonaInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildsPersonaInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgAccountGuildsPersonaInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

