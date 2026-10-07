# <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_Types_Data"></a> Class CMsgShowcaseBackground.Types.Data

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgShowcaseBackground.Types.Data : IMessage<CMsgShowcaseBackground.Types.Data>, IEquatable<CMsgShowcaseBackground.Types.Data>, IDeepCloneable<CMsgShowcaseBackground.Types.Data>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgShowcaseBackground.Types.Data](Divine.Protobufs.Dota2.CMsgShowcaseBackground.Types.Data.md)

#### Implements

IMessage<CMsgShowcaseBackground.Types.Data\>, 
[IEquatable<CMsgShowcaseBackground.Types.Data\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgShowcaseBackground.Types.Data\>, 
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
[EnumerableExtensions.In<CMsgShowcaseBackground.Types.Data\>\(CMsgShowcaseBackground.Types.Data, params CMsgShowcaseBackground.Types.Data\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_Types_Data__ctor"></a> Data\(\)

```csharp
public Data()
```

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_Types_Data__ctor_Divine_Protobufs_Dota2_CMsgShowcaseBackground_Types_Data_"></a> Data\(Data\)

```csharp
public Data(CMsgShowcaseBackground.Types.Data other)
```

#### Parameters

`other` [CMsgShowcaseBackground](Divine.Protobufs.Dota2.CMsgShowcaseBackground.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseBackground.Types.md).[Data](Divine.Protobufs.Dota2.CMsgShowcaseBackground.Types.Data.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_Types_Data_LoadingScreenFieldNumber"></a> LoadingScreenFieldNumber

```csharp
public const int LoadingScreenFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_Types_Data_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_Types_Data_LoadingScreen"></a> LoadingScreen

```csharp
public CSOEconItem LoadingScreen { get; set; }
```

#### Property Value

 [CSOEconItem](Divine.Protobufs.Dota2.CSOEconItem.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_Types_Data_Parser"></a> Parser

```csharp
public static MessageParser<CMsgShowcaseBackground.Types.Data> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgShowcaseBackground](Divine.Protobufs.Dota2.CMsgShowcaseBackground.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseBackground.Types.md).[Data](Divine.Protobufs.Dota2.CMsgShowcaseBackground.Types.Data.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_Types_Data_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_Types_Data_Clone"></a> Clone\(\)

```csharp
public CMsgShowcaseBackground.Types.Data Clone()
```

#### Returns

 [CMsgShowcaseBackground](Divine.Protobufs.Dota2.CMsgShowcaseBackground.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseBackground.Types.md).[Data](Divine.Protobufs.Dota2.CMsgShowcaseBackground.Types.Data.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_Types_Data_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_Types_Data_Equals_Divine_Protobufs_Dota2_CMsgShowcaseBackground_Types_Data_"></a> Equals\(Data\)

```csharp
public bool Equals(CMsgShowcaseBackground.Types.Data other)
```

#### Parameters

`other` [CMsgShowcaseBackground](Divine.Protobufs.Dota2.CMsgShowcaseBackground.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseBackground.Types.md).[Data](Divine.Protobufs.Dota2.CMsgShowcaseBackground.Types.Data.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_Types_Data_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_Types_Data_MergeFrom_Divine_Protobufs_Dota2_CMsgShowcaseBackground_Types_Data_"></a> MergeFrom\(Data\)

```csharp
public void MergeFrom(CMsgShowcaseBackground.Types.Data other)
```

#### Parameters

`other` [CMsgShowcaseBackground](Divine.Protobufs.Dota2.CMsgShowcaseBackground.md).[Types](Divine.Protobufs.Dota2.CMsgShowcaseBackground.Types.md).[Data](Divine.Protobufs.Dota2.CMsgShowcaseBackground.Types.Data.md)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_Types_Data_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_Types_Data_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgShowcaseBackground_Types_Data_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

