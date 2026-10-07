# <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameUserData"></a> Class CMsgOverworldMinigameUserData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgOverworldMinigameUserData : IMessage<CMsgOverworldMinigameUserData>, IEquatable<CMsgOverworldMinigameUserData>, IDeepCloneable<CMsgOverworldMinigameUserData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgOverworldMinigameUserData](Divine.Protobufs.Dota2.CMsgOverworldMinigameUserData.md)

#### Implements

IMessage<CMsgOverworldMinigameUserData\>, 
[IEquatable<CMsgOverworldMinigameUserData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgOverworldMinigameUserData\>, 
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
[EnumerableExtensions.In<CMsgOverworldMinigameUserData\>\(CMsgOverworldMinigameUserData, params CMsgOverworldMinigameUserData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameUserData__ctor"></a> CMsgOverworldMinigameUserData\(\)

```csharp
public CMsgOverworldMinigameUserData()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameUserData__ctor_Divine_Protobufs_Dota2_CMsgOverworldMinigameUserData_"></a> CMsgOverworldMinigameUserData\(CMsgOverworldMinigameUserData\)

```csharp
public CMsgOverworldMinigameUserData(CMsgOverworldMinigameUserData other)
```

#### Parameters

`other` [CMsgOverworldMinigameUserData](Divine.Protobufs.Dota2.CMsgOverworldMinigameUserData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameUserData_CurrencyAmountFieldNumber"></a> CurrencyAmountFieldNumber

```csharp
public const int CurrencyAmountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameUserData_CustomDataFieldNumber"></a> CustomDataFieldNumber

```csharp
public const int CustomDataFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameUserData_NodeIdFieldNumber"></a> NodeIdFieldNumber

```csharp
public const int NodeIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameUserData_CurrencyAmount"></a> CurrencyAmount

```csharp
public uint CurrencyAmount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameUserData_CustomData"></a> CustomData

```csharp
public CMsgOverworldMinigameCustomData CustomData { get; set; }
```

#### Property Value

 [CMsgOverworldMinigameCustomData](Divine.Protobufs.Dota2.CMsgOverworldMinigameCustomData.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameUserData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameUserData_HasCurrencyAmount"></a> HasCurrencyAmount

```csharp
public bool HasCurrencyAmount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameUserData_HasNodeId"></a> HasNodeId

```csharp
public bool HasNodeId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameUserData_NodeId"></a> NodeId

```csharp
public uint NodeId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameUserData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgOverworldMinigameUserData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgOverworldMinigameUserData](Divine.Protobufs.Dota2.CMsgOverworldMinigameUserData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameUserData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameUserData_ClearCurrencyAmount"></a> ClearCurrencyAmount\(\)

```csharp
public void ClearCurrencyAmount()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameUserData_ClearNodeId"></a> ClearNodeId\(\)

```csharp
public void ClearNodeId()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameUserData_Clone"></a> Clone\(\)

```csharp
public CMsgOverworldMinigameUserData Clone()
```

#### Returns

 [CMsgOverworldMinigameUserData](Divine.Protobufs.Dota2.CMsgOverworldMinigameUserData.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameUserData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameUserData_Equals_Divine_Protobufs_Dota2_CMsgOverworldMinigameUserData_"></a> Equals\(CMsgOverworldMinigameUserData\)

```csharp
public bool Equals(CMsgOverworldMinigameUserData other)
```

#### Parameters

`other` [CMsgOverworldMinigameUserData](Divine.Protobufs.Dota2.CMsgOverworldMinigameUserData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameUserData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameUserData_MergeFrom_Divine_Protobufs_Dota2_CMsgOverworldMinigameUserData_"></a> MergeFrom\(CMsgOverworldMinigameUserData\)

```csharp
public void MergeFrom(CMsgOverworldMinigameUserData other)
```

#### Parameters

`other` [CMsgOverworldMinigameUserData](Divine.Protobufs.Dota2.CMsgOverworldMinigameUserData.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameUserData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameUserData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameUserData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

