# <a id="Divine_Protobufs_Dota2_CMsgPullTabsData"></a> Class CMsgPullTabsData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPullTabsData : IMessage<CMsgPullTabsData>, IEquatable<CMsgPullTabsData>, IDeepCloneable<CMsgPullTabsData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPullTabsData](Divine.Protobufs.Dota2.CMsgPullTabsData.md)

#### Implements

IMessage<CMsgPullTabsData\>, 
[IEquatable<CMsgPullTabsData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPullTabsData\>, 
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
[EnumerableExtensions.In<CMsgPullTabsData\>\(CMsgPullTabsData, params CMsgPullTabsData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData__ctor"></a> CMsgPullTabsData\(\)

```csharp
public CMsgPullTabsData()
```

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData__ctor_Divine_Protobufs_Dota2_CMsgPullTabsData_"></a> CMsgPullTabsData\(CMsgPullTabsData\)

```csharp
public CMsgPullTabsData(CMsgPullTabsData other)
```

#### Parameters

`other` [CMsgPullTabsData](Divine.Protobufs.Dota2.CMsgPullTabsData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_JackpotsFieldNumber"></a> JackpotsFieldNumber

```csharp
public const int JackpotsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_LastBoardFieldNumber"></a> LastBoardFieldNumber

```csharp
public const int LastBoardFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_SlotsFieldNumber"></a> SlotsFieldNumber

```csharp
public const int SlotsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_HasLastBoard"></a> HasLastBoard

```csharp
public bool HasLastBoard { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Jackpots"></a> Jackpots

```csharp
public RepeatedField<CMsgPullTabsData.Types.Jackpot> Jackpots { get; }
```

#### Property Value

 RepeatedField<[CMsgPullTabsData](Divine.Protobufs.Dota2.CMsgPullTabsData.md).[Types](Divine.Protobufs.Dota2.CMsgPullTabsData.Types.md).[Jackpot](Divine.Protobufs.Dota2.CMsgPullTabsData.Types.Jackpot.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_LastBoard"></a> LastBoard

```csharp
public uint LastBoard { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPullTabsData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPullTabsData](Divine.Protobufs.Dota2.CMsgPullTabsData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Slots"></a> Slots

```csharp
public RepeatedField<CMsgPullTabsData.Types.Slot> Slots { get; }
```

#### Property Value

 RepeatedField<[CMsgPullTabsData](Divine.Protobufs.Dota2.CMsgPullTabsData.md).[Types](Divine.Protobufs.Dota2.CMsgPullTabsData.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgPullTabsData.Types.Slot.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_ClearLastBoard"></a> ClearLastBoard\(\)

```csharp
public void ClearLastBoard()
```

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Clone"></a> Clone\(\)

```csharp
public CMsgPullTabsData Clone()
```

#### Returns

 [CMsgPullTabsData](Divine.Protobufs.Dota2.CMsgPullTabsData.md)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_Equals_Divine_Protobufs_Dota2_CMsgPullTabsData_"></a> Equals\(CMsgPullTabsData\)

```csharp
public bool Equals(CMsgPullTabsData other)
```

#### Parameters

`other` [CMsgPullTabsData](Divine.Protobufs.Dota2.CMsgPullTabsData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_MergeFrom_Divine_Protobufs_Dota2_CMsgPullTabsData_"></a> MergeFrom\(CMsgPullTabsData\)

```csharp
public void MergeFrom(CMsgPullTabsData other)
```

#### Parameters

`other` [CMsgPullTabsData](Divine.Protobufs.Dota2.CMsgPullTabsData.md)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPullTabsData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

