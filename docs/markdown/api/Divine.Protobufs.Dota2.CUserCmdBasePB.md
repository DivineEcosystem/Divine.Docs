# <a id="Divine_Protobufs_Dota2_CUserCmdBasePB"></a> Class CUserCmdBasePB

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserCmdBasePB : IMessage<CUserCmdBasePB>, IEquatable<CUserCmdBasePB>, IDeepCloneable<CUserCmdBasePB>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserCmdBasePB](Divine.Protobufs.Dota2.CUserCmdBasePB.md)

#### Implements

IMessage<CUserCmdBasePB\>, 
[IEquatable<CUserCmdBasePB\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserCmdBasePB\>, 
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
[EnumerableExtensions.In<CUserCmdBasePB\>\(CUserCmdBasePB, params CUserCmdBasePB\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserCmdBasePB__ctor"></a> CUserCmdBasePB\(\)

```csharp
public CUserCmdBasePB()
```

### <a id="Divine_Protobufs_Dota2_CUserCmdBasePB__ctor_Divine_Protobufs_Dota2_CUserCmdBasePB_"></a> CUserCmdBasePB\(CUserCmdBasePB\)

```csharp
public CUserCmdBasePB(CUserCmdBasePB other)
```

#### Parameters

`other` [CUserCmdBasePB](Divine.Protobufs.Dota2.CUserCmdBasePB.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserCmdBasePB_BaseFieldNumber"></a> BaseFieldNumber

```csharp
public const int BaseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserCmdBasePB_Base"></a> Base

```csharp
public CBaseUserCmdPB Base { get; set; }
```

#### Property Value

 [CBaseUserCmdPB](Divine.Protobufs.Dota2.CBaseUserCmdPB.md)

### <a id="Divine_Protobufs_Dota2_CUserCmdBasePB_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserCmdBasePB_Parser"></a> Parser

```csharp
public static MessageParser<CUserCmdBasePB> Parser { get; }
```

#### Property Value

 MessageParser<[CUserCmdBasePB](Divine.Protobufs.Dota2.CUserCmdBasePB.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserCmdBasePB_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserCmdBasePB_Clone"></a> Clone\(\)

```csharp
public CUserCmdBasePB Clone()
```

#### Returns

 [CUserCmdBasePB](Divine.Protobufs.Dota2.CUserCmdBasePB.md)

### <a id="Divine_Protobufs_Dota2_CUserCmdBasePB_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserCmdBasePB_Equals_Divine_Protobufs_Dota2_CUserCmdBasePB_"></a> Equals\(CUserCmdBasePB\)

```csharp
public bool Equals(CUserCmdBasePB other)
```

#### Parameters

`other` [CUserCmdBasePB](Divine.Protobufs.Dota2.CUserCmdBasePB.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserCmdBasePB_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserCmdBasePB_MergeFrom_Divine_Protobufs_Dota2_CUserCmdBasePB_"></a> MergeFrom\(CUserCmdBasePB\)

```csharp
public void MergeFrom(CUserCmdBasePB other)
```

#### Parameters

`other` [CUserCmdBasePB](Divine.Protobufs.Dota2.CUserCmdBasePB.md)

### <a id="Divine_Protobufs_Dota2_CUserCmdBasePB_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserCmdBasePB_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserCmdBasePB_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

