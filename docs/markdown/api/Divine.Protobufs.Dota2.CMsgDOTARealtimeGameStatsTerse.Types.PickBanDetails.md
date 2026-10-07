# <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PickBanDetails"></a> Class CMsgDOTARealtimeGameStatsTerse.Types.PickBanDetails

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTARealtimeGameStatsTerse.Types.PickBanDetails : IMessage<CMsgDOTARealtimeGameStatsTerse.Types.PickBanDetails>, IEquatable<CMsgDOTARealtimeGameStatsTerse.Types.PickBanDetails>, IDeepCloneable<CMsgDOTARealtimeGameStatsTerse.Types.PickBanDetails>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTARealtimeGameStatsTerse.Types.PickBanDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.PickBanDetails.md)

#### Implements

IMessage<CMsgDOTARealtimeGameStatsTerse.Types.PickBanDetails\>, 
[IEquatable<CMsgDOTARealtimeGameStatsTerse.Types.PickBanDetails\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTARealtimeGameStatsTerse.Types.PickBanDetails\>, 
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
[EnumerableExtensions.In<CMsgDOTARealtimeGameStatsTerse.Types.PickBanDetails\>\(CMsgDOTARealtimeGameStatsTerse.Types.PickBanDetails, params CMsgDOTARealtimeGameStatsTerse.Types.PickBanDetails\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PickBanDetails__ctor"></a> PickBanDetails\(\)

```csharp
public PickBanDetails()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PickBanDetails__ctor_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PickBanDetails_"></a> PickBanDetails\(PickBanDetails\)

```csharp
public PickBanDetails(CMsgDOTARealtimeGameStatsTerse.Types.PickBanDetails other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.md).[PickBanDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.PickBanDetails.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PickBanDetails_HeroFieldNumber"></a> HeroFieldNumber

```csharp
public const int HeroFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PickBanDetails_TeamFieldNumber"></a> TeamFieldNumber

```csharp
public const int TeamFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PickBanDetails_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PickBanDetails_HasHero"></a> HasHero

```csharp
public bool HasHero { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PickBanDetails_HasTeam"></a> HasTeam

```csharp
public bool HasTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PickBanDetails_Hero"></a> Hero

```csharp
public int Hero { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PickBanDetails_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTARealtimeGameStatsTerse.Types.PickBanDetails> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.md).[PickBanDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.PickBanDetails.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PickBanDetails_Team"></a> Team

```csharp
public uint Team { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PickBanDetails_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PickBanDetails_ClearHero"></a> ClearHero\(\)

```csharp
public void ClearHero()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PickBanDetails_ClearTeam"></a> ClearTeam\(\)

```csharp
public void ClearTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PickBanDetails_Clone"></a> Clone\(\)

```csharp
public CMsgDOTARealtimeGameStatsTerse.Types.PickBanDetails Clone()
```

#### Returns

 [CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.md).[PickBanDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.PickBanDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PickBanDetails_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PickBanDetails_Equals_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PickBanDetails_"></a> Equals\(PickBanDetails\)

```csharp
public bool Equals(CMsgDOTARealtimeGameStatsTerse.Types.PickBanDetails other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.md).[PickBanDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.PickBanDetails.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PickBanDetails_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PickBanDetails_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PickBanDetails_"></a> MergeFrom\(PickBanDetails\)

```csharp
public void MergeFrom(CMsgDOTARealtimeGameStatsTerse.Types.PickBanDetails other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.md).[PickBanDetails](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.PickBanDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PickBanDetails_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PickBanDetails_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_PickBanDetails_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

