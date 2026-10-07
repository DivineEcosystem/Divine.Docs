# <a id="Divine_Protobufs_Dota2_CMsgRoadToTIUserData"></a> Class CMsgRoadToTIUserData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgRoadToTIUserData : IMessage<CMsgRoadToTIUserData>, IEquatable<CMsgRoadToTIUserData>, IDeepCloneable<CMsgRoadToTIUserData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgRoadToTIUserData](Divine.Protobufs.Dota2.CMsgRoadToTIUserData.md)

#### Implements

IMessage<CMsgRoadToTIUserData\>, 
[IEquatable<CMsgRoadToTIUserData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgRoadToTIUserData\>, 
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
[EnumerableExtensions.In<CMsgRoadToTIUserData\>\(CMsgRoadToTIUserData, params CMsgRoadToTIUserData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIUserData__ctor"></a> CMsgRoadToTIUserData\(\)

```csharp
public CMsgRoadToTIUserData()
```

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIUserData__ctor_Divine_Protobufs_Dota2_CMsgRoadToTIUserData_"></a> CMsgRoadToTIUserData\(CMsgRoadToTIUserData\)

```csharp
public CMsgRoadToTIUserData(CMsgRoadToTIUserData other)
```

#### Parameters

`other` [CMsgRoadToTIUserData](Divine.Protobufs.Dota2.CMsgRoadToTIUserData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIUserData_QuestsFieldNumber"></a> QuestsFieldNumber

```csharp
public const int QuestsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIUserData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIUserData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgRoadToTIUserData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgRoadToTIUserData](Divine.Protobufs.Dota2.CMsgRoadToTIUserData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIUserData_Quests"></a> Quests

```csharp
public RepeatedField<CMsgRoadToTIAssignedQuest> Quests { get; }
```

#### Property Value

 RepeatedField<[CMsgRoadToTIAssignedQuest](Divine.Protobufs.Dota2.CMsgRoadToTIAssignedQuest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIUserData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIUserData_Clone"></a> Clone\(\)

```csharp
public CMsgRoadToTIUserData Clone()
```

#### Returns

 [CMsgRoadToTIUserData](Divine.Protobufs.Dota2.CMsgRoadToTIUserData.md)

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIUserData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIUserData_Equals_Divine_Protobufs_Dota2_CMsgRoadToTIUserData_"></a> Equals\(CMsgRoadToTIUserData\)

```csharp
public bool Equals(CMsgRoadToTIUserData other)
```

#### Parameters

`other` [CMsgRoadToTIUserData](Divine.Protobufs.Dota2.CMsgRoadToTIUserData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIUserData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIUserData_MergeFrom_Divine_Protobufs_Dota2_CMsgRoadToTIUserData_"></a> MergeFrom\(CMsgRoadToTIUserData\)

```csharp
public void MergeFrom(CMsgRoadToTIUserData other)
```

#### Parameters

`other` [CMsgRoadToTIUserData](Divine.Protobufs.Dota2.CMsgRoadToTIUserData.md)

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIUserData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIUserData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgRoadToTIUserData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

