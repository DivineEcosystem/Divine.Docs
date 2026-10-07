# <a id="Divine_Protobufs_Dota2_CMvpData"></a> Class CMvpData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMvpData : IMessage<CMvpData>, IEquatable<CMvpData>, IDeepCloneable<CMvpData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMvpData](Divine.Protobufs.Dota2.CMvpData.md)

#### Implements

IMessage<CMvpData\>, 
[IEquatable<CMvpData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMvpData\>, 
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
[EnumerableExtensions.In<CMvpData\>\(CMvpData, params CMvpData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMvpData__ctor"></a> CMvpData\(\)

```csharp
public CMvpData()
```

### <a id="Divine_Protobufs_Dota2_CMvpData__ctor_Divine_Protobufs_Dota2_CMvpData_"></a> CMvpData\(CMvpData\)

```csharp
public CMvpData(CMvpData other)
```

#### Parameters

`other` [CMvpData](Divine.Protobufs.Dota2.CMvpData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMvpData_EventMvpsFieldNumber"></a> EventMvpsFieldNumber

```csharp
public const int EventMvpsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMvpData_MvpsFieldNumber"></a> MvpsFieldNumber

```csharp
public const int MvpsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMvpData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMvpData_EventMvps"></a> EventMvps

```csharp
public RepeatedField<CMvpData.Types.MvpDatum> EventMvps { get; }
```

#### Property Value

 RepeatedField<[CMvpData](Divine.Protobufs.Dota2.CMvpData.md).[Types](Divine.Protobufs.Dota2.CMvpData.Types.md).[MvpDatum](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.md)\>

### <a id="Divine_Protobufs_Dota2_CMvpData_Mvps"></a> Mvps

```csharp
public RepeatedField<CMvpData.Types.MvpDatum> Mvps { get; }
```

#### Property Value

 RepeatedField<[CMvpData](Divine.Protobufs.Dota2.CMvpData.md).[Types](Divine.Protobufs.Dota2.CMvpData.Types.md).[MvpDatum](Divine.Protobufs.Dota2.CMvpData.Types.MvpDatum.md)\>

### <a id="Divine_Protobufs_Dota2_CMvpData_Parser"></a> Parser

```csharp
public static MessageParser<CMvpData> Parser { get; }
```

#### Property Value

 MessageParser<[CMvpData](Divine.Protobufs.Dota2.CMvpData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMvpData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMvpData_Clone"></a> Clone\(\)

```csharp
public CMvpData Clone()
```

#### Returns

 [CMvpData](Divine.Protobufs.Dota2.CMvpData.md)

### <a id="Divine_Protobufs_Dota2_CMvpData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMvpData_Equals_Divine_Protobufs_Dota2_CMvpData_"></a> Equals\(CMvpData\)

```csharp
public bool Equals(CMvpData other)
```

#### Parameters

`other` [CMvpData](Divine.Protobufs.Dota2.CMvpData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMvpData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMvpData_MergeFrom_Divine_Protobufs_Dota2_CMvpData_"></a> MergeFrom\(CMvpData\)

```csharp
public void MergeFrom(CMvpData other)
```

#### Parameters

`other` [CMvpData](Divine.Protobufs.Dota2.CMvpData.md)

### <a id="Divine_Protobufs_Dota2_CMvpData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMvpData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMvpData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

