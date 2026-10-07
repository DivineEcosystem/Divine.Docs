# <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumData"></a> Class CMsgDOTACompendiumData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTACompendiumData : IMessage<CMsgDOTACompendiumData>, IEquatable<CMsgDOTACompendiumData>, IDeepCloneable<CMsgDOTACompendiumData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTACompendiumData](Divine.Protobufs.Dota2.CMsgDOTACompendiumData.md)

#### Implements

IMessage<CMsgDOTACompendiumData\>, 
[IEquatable<CMsgDOTACompendiumData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTACompendiumData\>, 
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
[EnumerableExtensions.In<CMsgDOTACompendiumData\>\(CMsgDOTACompendiumData, params CMsgDOTACompendiumData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumData__ctor"></a> CMsgDOTACompendiumData\(\)

```csharp
public CMsgDOTACompendiumData()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumData__ctor_Divine_Protobufs_Dota2_CMsgDOTACompendiumData_"></a> CMsgDOTACompendiumData\(CMsgDOTACompendiumData\)

```csharp
public CMsgDOTACompendiumData(CMsgDOTACompendiumData other)
```

#### Parameters

`other` [CMsgDOTACompendiumData](Divine.Protobufs.Dota2.CMsgDOTACompendiumData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumData_SelectionsFieldNumber"></a> SelectionsFieldNumber

```csharp
public const int SelectionsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTACompendiumData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTACompendiumData](Divine.Protobufs.Dota2.CMsgDOTACompendiumData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumData_Selections"></a> Selections

```csharp
public RepeatedField<CMsgDOTACompendiumSelection> Selections { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTACompendiumSelection](Divine.Protobufs.Dota2.CMsgDOTACompendiumSelection.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumData_Clone"></a> Clone\(\)

```csharp
public CMsgDOTACompendiumData Clone()
```

#### Returns

 [CMsgDOTACompendiumData](Divine.Protobufs.Dota2.CMsgDOTACompendiumData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumData_Equals_Divine_Protobufs_Dota2_CMsgDOTACompendiumData_"></a> Equals\(CMsgDOTACompendiumData\)

```csharp
public bool Equals(CMsgDOTACompendiumData other)
```

#### Parameters

`other` [CMsgDOTACompendiumData](Divine.Protobufs.Dota2.CMsgDOTACompendiumData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumData_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTACompendiumData_"></a> MergeFrom\(CMsgDOTACompendiumData\)

```csharp
public void MergeFrom(CMsgDOTACompendiumData other)
```

#### Parameters

`other` [CMsgDOTACompendiumData](Divine.Protobufs.Dota2.CMsgDOTACompendiumData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACompendiumData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

