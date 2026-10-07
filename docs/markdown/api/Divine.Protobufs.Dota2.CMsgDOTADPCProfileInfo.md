# <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo"></a> Class CMsgDOTADPCProfileInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTADPCProfileInfo : IMessage<CMsgDOTADPCProfileInfo>, IEquatable<CMsgDOTADPCProfileInfo>, IDeepCloneable<CMsgDOTADPCProfileInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTADPCProfileInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.md)

#### Implements

IMessage<CMsgDOTADPCProfileInfo\>, 
[IEquatable<CMsgDOTADPCProfileInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTADPCProfileInfo\>, 
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
[EnumerableExtensions.In<CMsgDOTADPCProfileInfo\>\(CMsgDOTADPCProfileInfo, params CMsgDOTADPCProfileInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo__ctor"></a> CMsgDOTADPCProfileInfo\(\)

```csharp
public CMsgDOTADPCProfileInfo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo__ctor_Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_"></a> CMsgDOTADPCProfileInfo\(CMsgDOTADPCProfileInfo\)

```csharp
public CMsgDOTADPCProfileInfo(CMsgDOTADPCProfileInfo other)
```

#### Parameters

`other` [CMsgDOTADPCProfileInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_DisabledNotificationsFieldNumber"></a> DisabledNotificationsFieldNumber

```csharp
public const int DisabledNotificationsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_FantasyInfoFieldNumber"></a> FantasyInfoFieldNumber

```csharp
public const int FantasyInfoFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_PlayerInfoFieldNumber"></a> PlayerInfoFieldNumber

```csharp
public const int PlayerInfoFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_PredictionInfoFieldNumber"></a> PredictionInfoFieldNumber

```csharp
public const int PredictionInfoFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_DisabledNotifications"></a> DisabledNotifications

```csharp
public RepeatedField<uint> DisabledNotifications { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_FantasyInfo"></a> FantasyInfo

```csharp
public CMsgDOTADPCProfileInfo.Types.FantasyInfo FantasyInfo { get; set; }
```

#### Property Value

 [CMsgDOTADPCProfileInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.Types.md).[FantasyInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.Types.FantasyInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTADPCProfileInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTADPCProfileInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_PlayerInfo"></a> PlayerInfo

```csharp
public CMsgDOTAPlayerInfo PlayerInfo { get; set; }
```

#### Property Value

 [CMsgDOTAPlayerInfo](Divine.Protobufs.Dota2.CMsgDOTAPlayerInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_PredictionInfo"></a> PredictionInfo

```csharp
public CMsgDOTADPCProfileInfo.Types.PredictionInfo PredictionInfo { get; set; }
```

#### Property Value

 [CMsgDOTADPCProfileInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.Types.md).[PredictionInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.Types.PredictionInfo.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Clone"></a> Clone\(\)

```csharp
public CMsgDOTADPCProfileInfo Clone()
```

#### Returns

 [CMsgDOTADPCProfileInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_Equals_Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_"></a> Equals\(CMsgDOTADPCProfileInfo\)

```csharp
public bool Equals(CMsgDOTADPCProfileInfo other)
```

#### Parameters

`other` [CMsgDOTADPCProfileInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_"></a> MergeFrom\(CMsgDOTADPCProfileInfo\)

```csharp
public void MergeFrom(CMsgDOTADPCProfileInfo other)
```

#### Parameters

`other` [CMsgDOTADPCProfileInfo](Divine.Protobufs.Dota2.CMsgDOTADPCProfileInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTADPCProfileInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

