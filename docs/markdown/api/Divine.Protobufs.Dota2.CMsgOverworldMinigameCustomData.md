# <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameCustomData"></a> Class CMsgOverworldMinigameCustomData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgOverworldMinigameCustomData : IMessage<CMsgOverworldMinigameCustomData>, IEquatable<CMsgOverworldMinigameCustomData>, IDeepCloneable<CMsgOverworldMinigameCustomData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgOverworldMinigameCustomData](Divine.Protobufs.Dota2.CMsgOverworldMinigameCustomData.md)

#### Implements

IMessage<CMsgOverworldMinigameCustomData\>, 
[IEquatable<CMsgOverworldMinigameCustomData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgOverworldMinigameCustomData\>, 
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
[EnumerableExtensions.In<CMsgOverworldMinigameCustomData\>\(CMsgOverworldMinigameCustomData, params CMsgOverworldMinigameCustomData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameCustomData__ctor"></a> CMsgOverworldMinigameCustomData\(\)

```csharp
public CMsgOverworldMinigameCustomData()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameCustomData__ctor_Divine_Protobufs_Dota2_CMsgOverworldMinigameCustomData_"></a> CMsgOverworldMinigameCustomData\(CMsgOverworldMinigameCustomData\)

```csharp
public CMsgOverworldMinigameCustomData(CMsgOverworldMinigameCustomData other)
```

#### Parameters

`other` [CMsgOverworldMinigameCustomData](Divine.Protobufs.Dota2.CMsgOverworldMinigameCustomData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameCustomData_SurvivorsDataFieldNumber"></a> SurvivorsDataFieldNumber

```csharp
public const int SurvivorsDataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameCustomData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameCustomData_MinigameTypeCase"></a> MinigameTypeCase

```csharp
public CMsgOverworldMinigameCustomData.MinigameTypeOneofCase MinigameTypeCase { get; }
```

#### Property Value

 [CMsgOverworldMinigameCustomData](Divine.Protobufs.Dota2.CMsgOverworldMinigameCustomData.md).[MinigameTypeOneofCase](Divine.Protobufs.Dota2.CMsgOverworldMinigameCustomData.MinigameTypeOneofCase.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameCustomData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgOverworldMinigameCustomData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgOverworldMinigameCustomData](Divine.Protobufs.Dota2.CMsgOverworldMinigameCustomData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameCustomData_SurvivorsData"></a> SurvivorsData

```csharp
public CMsgSurvivorsUserData SurvivorsData { get; set; }
```

#### Property Value

 [CMsgSurvivorsUserData](Divine.Protobufs.Dota2.CMsgSurvivorsUserData.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameCustomData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameCustomData_ClearMinigameType"></a> ClearMinigameType\(\)

```csharp
public void ClearMinigameType()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameCustomData_Clone"></a> Clone\(\)

```csharp
public CMsgOverworldMinigameCustomData Clone()
```

#### Returns

 [CMsgOverworldMinigameCustomData](Divine.Protobufs.Dota2.CMsgOverworldMinigameCustomData.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameCustomData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameCustomData_Equals_Divine_Protobufs_Dota2_CMsgOverworldMinigameCustomData_"></a> Equals\(CMsgOverworldMinigameCustomData\)

```csharp
public bool Equals(CMsgOverworldMinigameCustomData other)
```

#### Parameters

`other` [CMsgOverworldMinigameCustomData](Divine.Protobufs.Dota2.CMsgOverworldMinigameCustomData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameCustomData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameCustomData_MergeFrom_Divine_Protobufs_Dota2_CMsgOverworldMinigameCustomData_"></a> MergeFrom\(CMsgOverworldMinigameCustomData\)

```csharp
public void MergeFrom(CMsgOverworldMinigameCustomData other)
```

#### Parameters

`other` [CMsgOverworldMinigameCustomData](Divine.Protobufs.Dota2.CMsgOverworldMinigameCustomData.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameCustomData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameCustomData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldMinigameCustomData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

