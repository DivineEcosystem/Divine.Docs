# <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI9"></a> Class CMsgGCToClientBattlePassRollup\_TI9

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientBattlePassRollup_TI9 : IMessage<CMsgGCToClientBattlePassRollup_TI9>, IEquatable<CMsgGCToClientBattlePassRollup_TI9>, IDeepCloneable<CMsgGCToClientBattlePassRollup_TI9>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientBattlePassRollup\_TI9](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI9.md)

#### Implements

IMessage<CMsgGCToClientBattlePassRollup\_TI9\>, 
[IEquatable<CMsgGCToClientBattlePassRollup\_TI9\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientBattlePassRollup\_TI9\>, 
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
[EnumerableExtensions.In<CMsgGCToClientBattlePassRollup\_TI9\>\(CMsgGCToClientBattlePassRollup\_TI9, params CMsgGCToClientBattlePassRollup\_TI9\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI9__ctor"></a> CMsgGCToClientBattlePassRollup\_TI9\(\)

```csharp
public CMsgGCToClientBattlePassRollup_TI9()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI9__ctor_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI9_"></a> CMsgGCToClientBattlePassRollup\_TI9\(CMsgGCToClientBattlePassRollup\_TI9\)

```csharp
public CMsgGCToClientBattlePassRollup_TI9(CMsgGCToClientBattlePassRollup_TI9 other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollup\_TI9](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI9.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI9_BattlePassLevelFieldNumber"></a> BattlePassLevelFieldNumber

```csharp
public const int BattlePassLevelFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI9_BattlePassLevel"></a> BattlePassLevel

```csharp
public uint BattlePassLevel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI9_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI9_HasBattlePassLevel"></a> HasBattlePassLevel

```csharp
public bool HasBattlePassLevel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI9_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientBattlePassRollup_TI9> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientBattlePassRollup\_TI9](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI9.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI9_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI9_ClearBattlePassLevel"></a> ClearBattlePassLevel\(\)

```csharp
public void ClearBattlePassLevel()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI9_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientBattlePassRollup_TI9 Clone()
```

#### Returns

 [CMsgGCToClientBattlePassRollup\_TI9](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI9.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI9_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI9_Equals_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI9_"></a> Equals\(CMsgGCToClientBattlePassRollup\_TI9\)

```csharp
public bool Equals(CMsgGCToClientBattlePassRollup_TI9 other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollup\_TI9](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI9.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI9_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI9_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI9_"></a> MergeFrom\(CMsgGCToClientBattlePassRollup\_TI9\)

```csharp
public void MergeFrom(CMsgGCToClientBattlePassRollup_TI9 other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollup\_TI9](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollup\_TI9.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI9_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI9_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollup_TI9_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

