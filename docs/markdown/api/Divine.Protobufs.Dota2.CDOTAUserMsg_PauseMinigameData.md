# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData"></a> Class CDOTAUserMsg\_PauseMinigameData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_PauseMinigameData : IMessage<CDOTAUserMsg_PauseMinigameData>, IEquatable<CDOTAUserMsg_PauseMinigameData>, IDeepCloneable<CDOTAUserMsg_PauseMinigameData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_PauseMinigameData](Divine.Protobufs.Dota2.CDOTAUserMsg\_PauseMinigameData.md)

#### Implements

IMessage<CDOTAUserMsg\_PauseMinigameData\>, 
[IEquatable<CDOTAUserMsg\_PauseMinigameData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_PauseMinigameData\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_PauseMinigameData\>\(CDOTAUserMsg\_PauseMinigameData, params CDOTAUserMsg\_PauseMinigameData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData__ctor"></a> CDOTAUserMsg\_PauseMinigameData\(\)

```csharp
public CDOTAUserMsg_PauseMinigameData()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_"></a> CDOTAUserMsg\_PauseMinigameData\(CDOTAUserMsg\_PauseMinigameData\)

```csharp
public CDOTAUserMsg_PauseMinigameData(CDOTAUserMsg_PauseMinigameData other)
```

#### Parameters

`other` [CDOTAUserMsg\_PauseMinigameData](Divine.Protobufs.Dota2.CDOTAUserMsg\_PauseMinigameData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_DataBitsFieldNumber"></a> DataBitsFieldNumber

```csharp
public const int DataBitsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_DataBits"></a> DataBits

```csharp
public RepeatedField<CDOTAUserMsg_PauseMinigameData.Types.DataBit> DataBits { get; }
```

#### Property Value

 RepeatedField<[CDOTAUserMsg\_PauseMinigameData](Divine.Protobufs.Dota2.CDOTAUserMsg\_PauseMinigameData.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_PauseMinigameData.Types.md).[DataBit](Divine.Protobufs.Dota2.CDOTAUserMsg\_PauseMinigameData.Types.DataBit.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_PauseMinigameData> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_PauseMinigameData](Divine.Protobufs.Dota2.CDOTAUserMsg\_PauseMinigameData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_PauseMinigameData Clone()
```

#### Returns

 [CDOTAUserMsg\_PauseMinigameData](Divine.Protobufs.Dota2.CDOTAUserMsg\_PauseMinigameData.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_"></a> Equals\(CDOTAUserMsg\_PauseMinigameData\)

```csharp
public bool Equals(CDOTAUserMsg_PauseMinigameData other)
```

#### Parameters

`other` [CDOTAUserMsg\_PauseMinigameData](Divine.Protobufs.Dota2.CDOTAUserMsg\_PauseMinigameData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_"></a> MergeFrom\(CDOTAUserMsg\_PauseMinigameData\)

```csharp
public void MergeFrom(CDOTAUserMsg_PauseMinigameData other)
```

#### Parameters

`other` [CDOTAUserMsg\_PauseMinigameData](Divine.Protobufs.Dota2.CDOTAUserMsg\_PauseMinigameData.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PauseMinigameData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

