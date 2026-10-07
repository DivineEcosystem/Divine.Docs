# <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyRichPresence_Types_Member"></a> Class CMsgDOTAPartyRichPresence.Types.Member

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAPartyRichPresence.Types.Member : IMessage<CMsgDOTAPartyRichPresence.Types.Member>, IEquatable<CMsgDOTAPartyRichPresence.Types.Member>, IDeepCloneable<CMsgDOTAPartyRichPresence.Types.Member>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAPartyRichPresence.Types.Member](Divine.Protobufs.Dota2.CMsgDOTAPartyRichPresence.Types.Member.md)

#### Implements

IMessage<CMsgDOTAPartyRichPresence.Types.Member\>, 
[IEquatable<CMsgDOTAPartyRichPresence.Types.Member\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAPartyRichPresence.Types.Member\>, 
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
[EnumerableExtensions.In<CMsgDOTAPartyRichPresence.Types.Member\>\(CMsgDOTAPartyRichPresence.Types.Member, params CMsgDOTAPartyRichPresence.Types.Member\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyRichPresence_Types_Member__ctor"></a> Member\(\)

```csharp
public Member()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyRichPresence_Types_Member__ctor_Divine_Protobufs_Dota2_CMsgDOTAPartyRichPresence_Types_Member_"></a> Member\(Member\)

```csharp
public Member(CMsgDOTAPartyRichPresence.Types.Member other)
```

#### Parameters

`other` [CMsgDOTAPartyRichPresence](Divine.Protobufs.Dota2.CMsgDOTAPartyRichPresence.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAPartyRichPresence.Types.md).[Member](Divine.Protobufs.Dota2.CMsgDOTAPartyRichPresence.Types.Member.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyRichPresence_Types_Member_CoachFieldNumber"></a> CoachFieldNumber

```csharp
public const int CoachFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyRichPresence_Types_Member_SteamIdFieldNumber"></a> SteamIdFieldNumber

```csharp
public const int SteamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyRichPresence_Types_Member_Coach"></a> Coach

```csharp
public bool Coach { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyRichPresence_Types_Member_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyRichPresence_Types_Member_HasCoach"></a> HasCoach

```csharp
public bool HasCoach { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyRichPresence_Types_Member_HasSteamId"></a> HasSteamId

```csharp
public bool HasSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyRichPresence_Types_Member_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAPartyRichPresence.Types.Member> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAPartyRichPresence](Divine.Protobufs.Dota2.CMsgDOTAPartyRichPresence.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAPartyRichPresence.Types.md).[Member](Divine.Protobufs.Dota2.CMsgDOTAPartyRichPresence.Types.Member.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyRichPresence_Types_Member_SteamId"></a> SteamId

```csharp
public ulong SteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyRichPresence_Types_Member_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyRichPresence_Types_Member_ClearCoach"></a> ClearCoach\(\)

```csharp
public void ClearCoach()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyRichPresence_Types_Member_ClearSteamId"></a> ClearSteamId\(\)

```csharp
public void ClearSteamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyRichPresence_Types_Member_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAPartyRichPresence.Types.Member Clone()
```

#### Returns

 [CMsgDOTAPartyRichPresence](Divine.Protobufs.Dota2.CMsgDOTAPartyRichPresence.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAPartyRichPresence.Types.md).[Member](Divine.Protobufs.Dota2.CMsgDOTAPartyRichPresence.Types.Member.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyRichPresence_Types_Member_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyRichPresence_Types_Member_Equals_Divine_Protobufs_Dota2_CMsgDOTAPartyRichPresence_Types_Member_"></a> Equals\(Member\)

```csharp
public bool Equals(CMsgDOTAPartyRichPresence.Types.Member other)
```

#### Parameters

`other` [CMsgDOTAPartyRichPresence](Divine.Protobufs.Dota2.CMsgDOTAPartyRichPresence.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAPartyRichPresence.Types.md).[Member](Divine.Protobufs.Dota2.CMsgDOTAPartyRichPresence.Types.Member.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyRichPresence_Types_Member_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyRichPresence_Types_Member_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAPartyRichPresence_Types_Member_"></a> MergeFrom\(Member\)

```csharp
public void MergeFrom(CMsgDOTAPartyRichPresence.Types.Member other)
```

#### Parameters

`other` [CMsgDOTAPartyRichPresence](Divine.Protobufs.Dota2.CMsgDOTAPartyRichPresence.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAPartyRichPresence.Types.md).[Member](Divine.Protobufs.Dota2.CMsgDOTAPartyRichPresence.Types.Member.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyRichPresence_Types_Member_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyRichPresence_Types_Member_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyRichPresence_Types_Member_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

