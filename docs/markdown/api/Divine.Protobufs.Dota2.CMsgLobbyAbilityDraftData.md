# <a id="Divine_Protobufs_Dota2_CMsgLobbyAbilityDraftData"></a> Class CMsgLobbyAbilityDraftData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgLobbyAbilityDraftData : IMessage<CMsgLobbyAbilityDraftData>, IEquatable<CMsgLobbyAbilityDraftData>, IDeepCloneable<CMsgLobbyAbilityDraftData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgLobbyAbilityDraftData](Divine.Protobufs.Dota2.CMsgLobbyAbilityDraftData.md)

#### Implements

IMessage<CMsgLobbyAbilityDraftData\>, 
[IEquatable<CMsgLobbyAbilityDraftData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgLobbyAbilityDraftData\>, 
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
[EnumerableExtensions.In<CMsgLobbyAbilityDraftData\>\(CMsgLobbyAbilityDraftData, params CMsgLobbyAbilityDraftData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgLobbyAbilityDraftData__ctor"></a> CMsgLobbyAbilityDraftData\(\)

```csharp
public CMsgLobbyAbilityDraftData()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyAbilityDraftData__ctor_Divine_Protobufs_Dota2_CMsgLobbyAbilityDraftData_"></a> CMsgLobbyAbilityDraftData\(CMsgLobbyAbilityDraftData\)

```csharp
public CMsgLobbyAbilityDraftData(CMsgLobbyAbilityDraftData other)
```

#### Parameters

`other` [CMsgLobbyAbilityDraftData](Divine.Protobufs.Dota2.CMsgLobbyAbilityDraftData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgLobbyAbilityDraftData_ShuffleDraftOrderFieldNumber"></a> ShuffleDraftOrderFieldNumber

```csharp
public const int ShuffleDraftOrderFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgLobbyAbilityDraftData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgLobbyAbilityDraftData_HasShuffleDraftOrder"></a> HasShuffleDraftOrder

```csharp
public bool HasShuffleDraftOrder { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyAbilityDraftData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgLobbyAbilityDraftData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgLobbyAbilityDraftData](Divine.Protobufs.Dota2.CMsgLobbyAbilityDraftData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgLobbyAbilityDraftData_ShuffleDraftOrder"></a> ShuffleDraftOrder

```csharp
public bool ShuffleDraftOrder { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgLobbyAbilityDraftData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyAbilityDraftData_ClearShuffleDraftOrder"></a> ClearShuffleDraftOrder\(\)

```csharp
public void ClearShuffleDraftOrder()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyAbilityDraftData_Clone"></a> Clone\(\)

```csharp
public CMsgLobbyAbilityDraftData Clone()
```

#### Returns

 [CMsgLobbyAbilityDraftData](Divine.Protobufs.Dota2.CMsgLobbyAbilityDraftData.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyAbilityDraftData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyAbilityDraftData_Equals_Divine_Protobufs_Dota2_CMsgLobbyAbilityDraftData_"></a> Equals\(CMsgLobbyAbilityDraftData\)

```csharp
public bool Equals(CMsgLobbyAbilityDraftData other)
```

#### Parameters

`other` [CMsgLobbyAbilityDraftData](Divine.Protobufs.Dota2.CMsgLobbyAbilityDraftData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyAbilityDraftData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyAbilityDraftData_MergeFrom_Divine_Protobufs_Dota2_CMsgLobbyAbilityDraftData_"></a> MergeFrom\(CMsgLobbyAbilityDraftData\)

```csharp
public void MergeFrom(CMsgLobbyAbilityDraftData other)
```

#### Parameters

`other` [CMsgLobbyAbilityDraftData](Divine.Protobufs.Dota2.CMsgLobbyAbilityDraftData.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyAbilityDraftData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgLobbyAbilityDraftData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyAbilityDraftData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

