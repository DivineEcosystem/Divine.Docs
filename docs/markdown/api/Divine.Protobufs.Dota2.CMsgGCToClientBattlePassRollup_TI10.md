# <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI10"></a> Class CMsgGCToClientBattlePassRollup\_TI10

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientBattlePassRollup_TI10 : IMessage<CMsgGCToClientBattlePassRollup_TI10>, IEquatable<CMsgGCToClientBattlePassRollup_TI10>, IDeepCloneable<CMsgGCToClientBattlePassRollup_TI10>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientBattlePassRollup\_TI10](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI10.md)

#### Implements

IMessage<CMsgGCToClientBattlePassRollup\_TI10\>, 
[IEquatable<CMsgGCToClientBattlePassRollup\_TI10\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientBattlePassRollup\_TI10\>, 
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
[EnumerableExtensions.In<CMsgGCToClientBattlePassRollup\_TI10\>\(CMsgGCToClientBattlePassRollup\_TI10, params CMsgGCToClientBattlePassRollup\_TI10\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI10__ctor"></a> CMsgGCToClientBattlePassRollup\_TI10\(\)

```csharp
public CMsgGCToClientBattlePassRollup_TI10()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI10__ctor_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI10_"></a> CMsgGCToClientBattlePassRollup\_TI10\(CMsgGCToClientBattlePassRollup\_TI10\)

```csharp
public CMsgGCToClientBattlePassRollup_TI10(CMsgGCToClientBattlePassRollup_TI10 other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollup\_TI10](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI10.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI10_BattlePassLevelFieldNumber"></a> BattlePassLevelFieldNumber

```csharp
public const int BattlePassLevelFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI10_BattlePassLevel"></a> BattlePassLevel

```csharp
public uint BattlePassLevel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI10_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI10_HasBattlePassLevel"></a> HasBattlePassLevel

```csharp
public bool HasBattlePassLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI10_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientBattlePassRollup_TI10> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientBattlePassRollup\_TI10](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI10.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI10_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI10_ClearBattlePassLevel"></a> ClearBattlePassLevel\(\)

```csharp
public void ClearBattlePassLevel()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI10_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientBattlePassRollup_TI10 Clone()
```

#### Returns

 [CMsgGCToClientBattlePassRollup\_TI10](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI10.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI10_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI10_Equals_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI10_"></a> Equals\(CMsgGCToClientBattlePassRollup\_TI10\)

```csharp
public bool Equals(CMsgGCToClientBattlePassRollup_TI10 other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollup\_TI10](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI10.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI10_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI10_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI10_"></a> MergeFrom\(CMsgGCToClientBattlePassRollup\_TI10\)

```csharp
public void MergeFrom(CMsgGCToClientBattlePassRollup_TI10 other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollup\_TI10](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI10.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI10_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI10_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI10_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

