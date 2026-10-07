# <a id="Divine_Protobufs_Dota2_CMsgSurvivorsUserData"></a> Class CMsgSurvivorsUserData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSurvivorsUserData : IMessage<CMsgSurvivorsUserData>, IEquatable<CMsgSurvivorsUserData>, IDeepCloneable<CMsgSurvivorsUserData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSurvivorsUserData](Divine.Protobufs.Dota2.CMsgSurvivorsUserData.md)

#### Implements

IMessage<CMsgSurvivorsUserData\>, 
[IEquatable<CMsgSurvivorsUserData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSurvivorsUserData\>, 
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
[EnumerableExtensions.In<CMsgSurvivorsUserData\>\(CMsgSurvivorsUserData, params CMsgSurvivorsUserData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSurvivorsUserData__ctor"></a> CMsgSurvivorsUserData\(\)

```csharp
public CMsgSurvivorsUserData()
```

### <a id="Divine_Protobufs_Dota2_CMsgSurvivorsUserData__ctor_Divine_Protobufs_Dota2_CMsgSurvivorsUserData_"></a> CMsgSurvivorsUserData\(CMsgSurvivorsUserData\)

```csharp
public CMsgSurvivorsUserData(CMsgSurvivorsUserData other)
```

#### Parameters

`other` [CMsgSurvivorsUserData](Divine.Protobufs.Dota2.CMsgSurvivorsUserData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSurvivorsUserData_AttributeLevelsFieldNumber"></a> AttributeLevelsFieldNumber

```csharp
public const int AttributeLevelsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSurvivorsUserData_UnlockedDifficultyFieldNumber"></a> UnlockedDifficultyFieldNumber

```csharp
public const int UnlockedDifficultyFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSurvivorsUserData_AttributeLevels"></a> AttributeLevels

```csharp
public MapField<int, uint> AttributeLevels { get; }
```

#### Property Value

 MapField<[int](https://learn.microsoft.com/dotnet/api/system.int32), [uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgSurvivorsUserData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSurvivorsUserData_HasUnlockedDifficulty"></a> HasUnlockedDifficulty

```csharp
public bool HasUnlockedDifficulty { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSurvivorsUserData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSurvivorsUserData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSurvivorsUserData](Divine.Protobufs.Dota2.CMsgSurvivorsUserData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSurvivorsUserData_UnlockedDifficulty"></a> UnlockedDifficulty

```csharp
public uint UnlockedDifficulty { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSurvivorsUserData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSurvivorsUserData_ClearUnlockedDifficulty"></a> ClearUnlockedDifficulty\(\)

```csharp
public void ClearUnlockedDifficulty()
```

### <a id="Divine_Protobufs_Dota2_CMsgSurvivorsUserData_Clone"></a> Clone\(\)

```csharp
public CMsgSurvivorsUserData Clone()
```

#### Returns

 [CMsgSurvivorsUserData](Divine.Protobufs.Dota2.CMsgSurvivorsUserData.md)

### <a id="Divine_Protobufs_Dota2_CMsgSurvivorsUserData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSurvivorsUserData_Equals_Divine_Protobufs_Dota2_CMsgSurvivorsUserData_"></a> Equals\(CMsgSurvivorsUserData\)

```csharp
public bool Equals(CMsgSurvivorsUserData other)
```

#### Parameters

`other` [CMsgSurvivorsUserData](Divine.Protobufs.Dota2.CMsgSurvivorsUserData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSurvivorsUserData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSurvivorsUserData_MergeFrom_Divine_Protobufs_Dota2_CMsgSurvivorsUserData_"></a> MergeFrom\(CMsgSurvivorsUserData\)

```csharp
public void MergeFrom(CMsgSurvivorsUserData other)
```

#### Parameters

`other` [CMsgSurvivorsUserData](Divine.Protobufs.Dota2.CMsgSurvivorsUserData.md)

### <a id="Divine_Protobufs_Dota2_CMsgSurvivorsUserData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSurvivorsUserData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSurvivorsUserData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

